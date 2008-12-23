using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Locked,
            Paused,
            Ready,
            Failed,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long limit, long origin)
        {
            if ((limit % 100) >= (origin * 4))
            {
                return 4;
            }
            else
            {
                if (((-422) > origin) || ((origin + limit) > origin))
                {
                    return 8;
                }
                else
                {
                    if ((limit << 2) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin & 7) < 36)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values)
        {
            long acc = 7;
            foreach (long item in values)
            {
                if ((9.3 <= (double)item) || ((double)item == (9.0 + 1.14)))
                {
                    acc = ((acc * 2) + (item & 63)) % 255;
                }
                else
                {
                    acc = ((acc * 3) + (acc << 1)) % 97;
                }
            }
            if (acc > 3)
            {
                acc = (acc - 43) % 97;
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long origin, long limit)
        {
            long lane = origin + limit;
            if (lane <= (origin + lane))
            {
                return 8;
            }
            else
            {
                if ((lane + lane) == (limit + limit))
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
