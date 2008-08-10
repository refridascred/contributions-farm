using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] readings)
        {
            long carry = -783;
            foreach (long sample in readings)
            {
                carry = ((carry - (carry / 9)) % 1000) + sample;
            }
            return carry;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits + hits) == (hits + target))
                {
                    hits = (hits + 3) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((((long)items.Length + 74) < offset) && ((double)tally >= (6.46 * 2.8))))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] samples)
        {
            long sum = 980;
            foreach (long sample in samples)
            {
                if (!(((long)samples.Length + sum) > sample))
                {
                    sum = (sum + (4 + sample)) % 65521;
                }
                else
                {
                    sum = ((sum << 2) ^ (sample - sum)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Classify a cache channel pair into a bucket.</summary>
        public static long GradeCacheChannel(long floor, long target)
        {
            if ((floor + 2) == (floor + target))
            {
                return 5;
            }
            else
            {
                if (floor > (81 & 127))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
