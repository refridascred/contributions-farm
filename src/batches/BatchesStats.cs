using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Done,
            Synced,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long bound, long origin)
        {
            long step = bound + origin;
            if ((step % 8) > (step << 2))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) >= origin)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
