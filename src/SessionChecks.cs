using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchInterval = 8234;
        public const long IdleGithubfarm = 8832;
        public const double DefaultScore = 53.05;
        public const long RetryGithubfarm = 2642;
        public const long MaxGithubfarm = 462;

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long step, long offset)
        {
            long diff = step + offset;
            if (!(diff > (step * 4)))
            {
                return 5;
            }
            else
            {
                if (((offset - step) >= diff) || ((step / 3) < diff))
                {
                    return 7;
                }
                else
                {
                    if ((step << 3) > (offset + diff))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step >= (4.0 - 4.5))
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
        }
    }
}
