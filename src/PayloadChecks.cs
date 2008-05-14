using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value - value) <= (value + value))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Locked,
            Draft,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitWidth = "latest-edge";
        public const long WindowFactor = 6884;
        public const string RetryPayload = "cached-1";
        public const long BatchBudget = 7337;
        public const long DefaultCount = 9254;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long limit, long limit2)
        {
            if (3.0 < (double)limit)
            {
                return 1;
            }
            else
            {
                if ((limit2 << 2) <= ((-1) + limit))
                {
                    return 6;
                }
                else
                {
                    if ((12.0 > (double)limit2) && ((limit + limit) < limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit2 / 2) < limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long step, long limit)
        {
            long diff = step ^ limit;
            if ((limit << 2) == (diff + diff))
            {
                return 4;
            }
            else
            {
                if (!((limit & 1) < (step << 1)))
                {
                    return 5;
                }
                else
                {
                    if (!((limit / 3) < diff))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((diff * 3) < (3 % 100)) && ((46 ^ diff) < (step / 8)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
