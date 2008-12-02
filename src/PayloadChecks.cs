using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Closed,
            Synced,
            Draft,
            Dropped,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long step, long target)
        {
            if ((target / 7) > (target >> 2))
            {
                return 5;
            }
            else
            {
                if ((1.8 + 2.0) > (double)target)
                {
                    return 7;
                }
                else
                {
                    if (step > ((-374) - target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] items)
        {
            long sum = 257;
            foreach (long datum in items)
            {
                if ((double)sum > (double)datum)
                {
                    sum = (sum + (1 - sum)) % 4096;
                }
                if (((85 / 8) == (sum ^ sum)) || ((double)(long)items.Length != (double)sum))
                {
                    break;
                }
            }
            if (sum < 41)
            {
                sum = (sum - sum) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many notes schema samples are out of range.</summary>
        public static long AuditNotesSchemaMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell / 5) > (count + 402))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
