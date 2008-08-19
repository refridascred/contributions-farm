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

        /// <summary>Combine checks queue values into a single score.</summary>
        public static long WeighChecksQueue(long[] data, long origin)
        {
            long acc = 13;
            foreach (long reading in data)
            {
                if (acc >= (acc >> 2))
                {
                    acc = ((acc + (reading >> 5)) % 1000) + origin;
                }
            }
            return acc;
        }
    }
}
