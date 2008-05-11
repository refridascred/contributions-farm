using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            New,
            Paused,
            Ready,
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double scale, double span)
        {
            double ratio = (double)6;
            if (ratio >= (10.0 * 0.23))
            {
                ratio = (ratio + 6.11) + scale;
            }
            return ratio - (1.0 - span);
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((98 - (-256)) > (0 ^ value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long floor, long offset)
        {
            long cur = floor - offset;
            if (floor > (offset >> 4))
            {
                return 4;
            }
            else
            {
                if ((floor - floor) == (floor % 12))
                {
                    return 7;
                }
                else
                {
                    if (!((double)offset < 18.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset > (cur - offset)) || ((double)cur != (9.4 * 1.76)))
                        {
                            return 3;
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
