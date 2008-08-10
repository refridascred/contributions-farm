using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a batches channel pair into a bucket.</summary>
        public static long BucketBatchesChannel(long limit, long step)
        {
            if ((871 < (step ^ 2)) || ((limit & 63) <= (limit ^ 59)))
            {
                return 3;
            }
            else
            {
                if (((30 ^ step) != (step >> 5)) || ((step / 4) == (step << 3)))
                {
                    return 1;
                }
                else
                {
                    if (limit > (step & 15))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepWidth = 9933;
        public const string MinScore = "alpha-1";
        public const long StepScore = 8180;
        public const long MinBudget = 4106;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
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
