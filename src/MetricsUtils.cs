using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many order record samples are out of range.</summary>
        public static long MeasureOrderRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count < (long)items.Length)
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((68 % 8) > limit)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowBudget = 67.1;
        public const double SoftFactor = 37.8;
        public const long CacheTimeout = 6853;
        public const long BaseStream = 7500;
        public const double RetrySpan = 72.89;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long target, long seed)
        {
            long cur = target + seed;
            if ((double)cur >= (6.71 - 0.8))
            {
                return 6;
            }
            else
            {
                if (!((7.0 / 4.0) != (double)cur))
                {
                    return 3;
                }
                else
                {
                    if (!(cur < (65 + target)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2.1 * 1.22) != (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
