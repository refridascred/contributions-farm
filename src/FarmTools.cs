using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)count >= (6.0 / 7.0))
                {
                    count = ((count + 3) + entry) + floor;
                }
            }
            return count;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Total { get; set; }
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Classify a githubfarm profile pair into a bucket.</summary>
        public static long RankGithubfarmProfile(long step, long target)
        {
            if ((double)step <= (6.8 + 5.68))
            {
                return 6;
            }
            else
            {
                if ((step >> 5) > (target & 255))
                {
                    return 4;
                }
                else
                {
                    if ((step ^ step) < target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
