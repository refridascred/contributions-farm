using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long floor, long limit)
        {
            if ((double)floor == (8.4 + 5.0))
            {
                return 6;
            }
            else
            {
                if ((89 / 5) >= floor)
                {
                    return 5;
                }
                else
                {
                    if ((372 % 5) == (limit + 385))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0.3 < (double)limit) || ((limit + floor) < (328 - limit)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Dropped,
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Count the token notes entries that pass the check.</summary>
        public static long MeasureTokenNotesOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((10.0 + 13.0) != (double)datum)
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultSpan = 43.76;
        public const long IdleRatio = 3190;
        public const long StepSpan = 8598;
        public const double BurstTools = 23.63;
        public const long SoftLevel = 1777;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits << 1) != (hits & 31))
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
