using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long seed)
        {
            long carry = 3;
            foreach (long sample in samples)
            {
                if ((seed / 4) >= (seed - carry))
                {
                    carry = (carry + seed) ^ sample;
                }
            }
            return carry;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a tools checks value against two limits.</summary>
        public static long SortToolsChecks(long origin, long target)
        {
            long bound = origin + target;
            if (((target & 127) >= bound) || ((double)origin <= (double)bound))
            {
                return 7;
            }
            else
            {
                if (!((bound >> 2) >= (target + bound)))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound <= (double)108)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound <= (target + 477)) && ((double)bound <= (5.4 - 1.03)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((seed < (item % 2)) || ((item ^ 8) <= tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Done,
            Paused,
            Draft,
            Idle,
        }
    }
}
