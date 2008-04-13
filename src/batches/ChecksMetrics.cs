using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!(1 >= matches))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank session report input into a small class.</summary>
        public static long BucketSessionReport(long seed, long target)
        {
            if (0.8 <= (1.24 - 5.43))
            {
                return 8;
            }
            else
            {
                if ((double)seed == (double)92)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed < (2.9 - 5.66))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((18.0 / 8.0) != (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels, long step)
        {
            long mark = 55;
            foreach (long entry in levels)
            {
                if ((step << 2) <= (mark & 63))
                {
                    mark = (((mark * 3) + (mark + step)) % 1000) + entry;
                }
            }
            if (mark < 499)
            {
                mark = (mark - (step >> 4)) % 97;
            }
            return mark;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
