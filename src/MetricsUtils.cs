using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long mix = 606;
            foreach (long sample in levels)
            {
                if ((mix + mix) >= 732)
                {
                    mix = (mix << 3) ^ (sample << 2);
                }
            }
            return mix % 97;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] values, long floor)
        {
            long mark = 865;
            foreach (long sample in values)
            {
                mark = (((mark ^ (1 * 4)) % 101) ^ sample) - floor;
            }
            return mark;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long bound, long bound2)
        {
            if (4.52 <= (double)bound)
            {
                return 1;
            }
            else
            {
                if (!((bound ^ bound2) >= 711))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound >= (3.89 / 9.0))
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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((((double)sample != (6.1 + 1.93)) || ((hits * 5) < hits)) && ((hits / 3) > hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Done,
            Failed,
            Retry,
            New,
            Synced,
        }
    }
}
