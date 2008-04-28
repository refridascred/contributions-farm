using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Queued,
            Active,
            Failed,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen + 0) < (limit ^ datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long origin, long bound)
        {
            if ((origin & 63) == (bound >> 2))
            {
                return 1;
            }
            else
            {
                if (!(3.18 < (double)origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin == (15.0 * 2.4))
                    {
                        return 7;
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
