using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] readings)
        {
            long anchor = 235;
            foreach (long entry in readings)
            {
                anchor = anchor - (entry ^ 30);
                if (((anchor + anchor) == (entry % 100)) || ((anchor - anchor) <= (47 + 14)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a metrics metric counter forward.</summary>
        public static long SeriesMetricsMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - ((long)i * 4)) % 1000;
                sum = (sum << 3) ^ (long)i;
                sum = (sum << 3) ^ (sum * 2);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSpan = "open-edge";
        public const double StepSchema = 93.34;
        public const double LimitSchema = 38.09;
        public const long IdleSize = 7126;
        public const double LimitBudget = 41.76;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry ^ (carry % 10)) % 101;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
