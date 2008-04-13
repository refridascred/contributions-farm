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

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
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

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series)
        {
            long mark = -28;
            foreach (long reading in series)
            {
                if ((mark - (long)series.Length) >= (mark - reading))
                {
                    mark = mark + (56 * 3);
                }
            }
            return mark % 97;
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
