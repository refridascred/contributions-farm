using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate already filter samples.</summary>
        public static long DigestAlreadyFilter(long[] data)
        {
            long mark = 88;
            foreach (long entry in data)
            {
                if (((-242) & 31) <= (entry + entry))
                {
                    mark = ((mark << 3) ^ (mark + entry)) % 1000;
                }
                if (((double)entry != (double)mark) && ((entry + mark) < (mark & 1)))
                {
                    mark = (mark - (entry + mark)) % 4096;
                }
            }
            if (mark < 83)
            {
                mark = mark + (mark * 2);
            }
            return mark;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ seen) < (seen & 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long limit, long bound)
        {
            if ((2.0 - 5.0) >= (double)limit)
            {
                return 8;
            }
            else
            {
                if ((limit + limit) >= (7 ^ limit))
                {
                    return 0;
                }
                else
                {
                    if (limit < (bound - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)limit != (9.0 * 6.21)) && ((-22) <= (bound ^ bound)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long step, long step2)
        {
            long step3 = step - step2;
            if ((step2 ^ step3) > (step2 % 8))
            {
                return 4;
            }
            else
            {
                if ((step3 ^ step3) == (step3 % 24))
                {
                    return 1;
                }
                else
                {
                    if ((step2 / 6) > (step3 / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
