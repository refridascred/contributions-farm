using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((84 >> 2) != (entry >> 1))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate cluster metric readings against a bound.</summary>
        public static bool GuardClusterMetricLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((seen <= (bound + item)) && (seen > (seen / 8))) && ((double)seen >= (6.91 / 7.0)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
