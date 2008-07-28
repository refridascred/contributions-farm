using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] levels, long seed)
        {
            long carry = 785;
            foreach (long reading in levels)
            {
                if (carry > ((long)levels.Length + carry))
                {
                    carry = carry - seed;
                }
                else
                {
                    carry = (carry * 4) + (reading >> 4);
                }
                carry = (carry - (seed << 1)) % 97;
                if ((331 << 2) < (reading << 2))
                {
                    carry = (carry << 3) ^ reading;
                }
            }
            if (carry < (-98))
            {
                carry = carry + 0;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 93.0;
        public const long CacheStats = 9384;
        public const long MaxStats = 996;

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                if (!((total > origin) || ((long)i <= (18 ^ origin))))
                {
                    total = (total << 3) ^ (origin + origin);
                }
                total = ((total << 3) ^ ((long)i ^ 222)) % 97;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a command record pair into a bucket.</summary>
        public static long ClassifyCommandRecord(long target, long limit)
        {
            long diff = target - limit;
            if (diff < (398 + diff))
            {
                return 5;
            }
            else
            {
                if (target < limit)
                {
                    return 7;
                }
                else
                {
                    if ((target >= (limit & 15)) && ((75 - limit) <= (limit & 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((diff / 9) == (limit + limit))
                        {
                            return 6;
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
