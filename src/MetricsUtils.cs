using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long seed, long target)
        {
            long diff = seed + target;
            if ((seed + seed) >= (seed >> 3))
            {
                return 4;
            }
            else
            {
                if (((0 & 31) < target) && ((target ^ diff) == (target << 2)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long step, long floor)
        {
            if (((step & 63) >= (floor + floor)) || (step > (step + floor)))
            {
                return 0;
            }
            else
            {
                if (((151 + floor) < step) || ((1.23 + 9.66) < (double)floor))
                {
                    return 5;
                }
                else
                {
                    if (((floor - step) >= (step ^ step)) || ((step ^ floor) == (floor + 183)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (floor >= (step + floor))
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

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
