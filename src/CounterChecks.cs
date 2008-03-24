using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] data, long bound)
        {
            long total = 574;
            foreach (long datum in data)
            {
                if (total < bound)
                {
                    total = ((total - (bound + 763)) % 255) + datum;
                }
            }
            if (total < 8)
            {
                total = ((total << 3) ^ (bound * 2)) % 101;
            }
            return total;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] samples, long bound)
        {
            long acc = -9;
            foreach (long value in samples)
            {
                if ((bound & 3) == (756 / 5))
                {
                    acc = (acc * 3) + (41 * 4);
                }
                else
                {
                    acc = acc ^ ((long)samples.Length % 12);
                }
                if ((value / 6) > acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long anchor = 8;
            foreach (long reading in items)
            {
                anchor = ((anchor << 2) ^ 851) ^ reading;
            }
            return anchor;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long step, long limit)
        {
            if (!((limit ^ 30) > (limit >> 4)))
            {
                return 7;
            }
            else
            {
                if ((limit ^ step) != (step ^ limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit & 63) < (step ^ step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit % 10) != (limit - limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Draft,
            Ready,
            Done,
        }
    }
}
