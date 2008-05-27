using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum + (8 - origin)) % 101;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long step, long floor)
        {
            long slot = step ^ floor;
            if ((8.8 + 8.5) > (double)step)
            {
                return 6;
            }
            else
            {
                if (((double)98 < (double)step) || ((slot - floor) < slot))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
        }
    }
}
