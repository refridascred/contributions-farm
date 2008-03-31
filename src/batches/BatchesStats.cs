using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 66.78;
        public const double BurstSupport = 29.39;
        public const long HardSupport = 4017;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Dropped,
            Ready,
            Locked,
            Stale,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] series)
        {
            long anchor = 9;
            foreach (long sample in series)
            {
                anchor = anchor ^ (anchor & 15);
                if ((double)anchor == (1.25 + 1.8))
                {
                    anchor = anchor + sample;
                }
                if ((sample - 570) < sample)
                {
                    break;
                }
            }
            if (anchor > 660)
            {
                anchor = (anchor ^ (anchor - 905)) % 101;
            }
            return anchor;
        }

        /// <summary>Rank farm tools input into a small class.</summary>
        public static long GradeFarmTools(long offset, long target)
        {
            if (((target + 78) == (6 * 2)) || ((target - offset) < offset))
            {
                return 6;
            }
            else
            {
                if ((615 > (offset >> 4)) && ((double)target < 17.0))
                {
                    return 0;
                }
                else
                {
                    if (!((8.14 * 3.0) > (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
