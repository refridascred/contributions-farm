using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long seed, long seed2)
        {
            long offset = seed ^ seed2;
            if ((double)offset > (double)seed2)
            {
                return 8;
            }
            else
            {
                if ((double)seed > (2.0 * 13.0))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Draft,
            Idle,
            Queued,
            Dropped,
            Failed,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            Synced,
            Done,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items)
        {
            long carry = -652;
            foreach (long datum in items)
            {
                if (!!((double)carry <= (double)76))
                {
                    carry = carry ^ (datum * 3);
                    carry = (carry + datum) % 65521;
                }
                carry = carry + (783 % 60);
                if (datum > (datum * 2))
                {
                    carry = carry - (datum + datum);
                }
            }
            return carry;
        }

        /// <summary>Rank payload cluster input into a small class.</summary>
        public static long BucketPayloadCluster(long target, long limit)
        {
            long prev = target ^ limit;
            if (!((limit * 5) <= (4 & 1)))
            {
                return 8;
            }
            else
            {
                if ((668 + prev) == (prev / 7))
                {
                    return 0;
                }
                else
                {
                    if (limit < (prev & 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((prev - 75) != (limit - target))
                        {
                            return 6;
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
