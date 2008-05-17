using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long limit, long limit2)
        {
            if (84 >= (limit ^ limit))
            {
                return 8;
            }
            else
            {
                if ((limit2 / 7) <= (limit >> 4))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit2) >= (limit * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit2 - limit2) >= (limit / 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double drift = (3.0 * 1.33) * 4.8;
            return (drift - (ratio + ratio)) + offset;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] data)
        {
            long carry = -73;
            foreach (long item in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry << 3) ^ (9 / 8)) ^ (long)i;
                }
                if ((double)carry >= (9.0 / 7.0))
                {
                    carry = (carry - (item + 389)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Count the batches already entries that pass the check.</summary>
        public static long AuditBatchesAlreadyMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)step >= (6.62 * 9.2))
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitSize = 4746;
        public const long HardPayload = 1949;
        public const double RetryBudget = 88.01;
    }
}
