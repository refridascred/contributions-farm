using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstLevel = 4.95;
        public const string CacheTimeout = "strict-edge";
        public const long IdleDepth = 2668;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long limit, long limit2)
        {
            if ((5.12 - 2.3) >= (double)limit)
            {
                return 5;
            }
            else
            {
                if (((double)limit2 != (0.82 - 6.6)) || ((double)limit2 < (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((limit2 - limit) <= limit2)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit != (double)208)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((925 + 47) == (count + count))
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value * 4) != (76 / 4))
                {
                    matches = (matches + 2) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
