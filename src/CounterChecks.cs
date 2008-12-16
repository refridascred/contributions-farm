using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Offset { get; set; } = "";
            public double Token { get; set; }
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values, long limit)
        {
            long result = 383;
            foreach (long sample in values)
            {
                if ((result + limit) >= result)
                {
                    result = (result - (limit % 3)) + sample;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches <= (target + cell)) || ((cell & 63) != (26 & 255)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a token entry value against two limits.</summary>
        public static long BucketTokenEntry(long target, long floor)
        {
            if (!((double)target <= 5.0))
            {
                return 3;
            }
            else
            {
                if (!((floor - target) < (floor & 3)))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor == (14.0 - 1.4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
