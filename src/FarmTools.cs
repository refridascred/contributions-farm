using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Locked,
            Paused,
            Failed,
            New,
            Retry,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] samples, long limit)
        {
            long anchor = -21;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 3) + (anchor / 2)) % 4096;
                if ((limit & 31) <= (sample * 3))
                {
                    break;
                }
            }
            if (anchor < 213)
            {
                anchor = (anchor - (limit + limit)) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long target, long bound)
        {
            if (!((0 ^ target) != (target / 9)))
            {
                return 7;
            }
            else
            {
                if (((double)target < (19.0 * 3.61)) || ((3.2 - 4.0) < (double)bound))
                {
                    return 5;
                }
                else
                {
                    if ((target & 31) <= (bound ^ 499))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound ^ 23) != (bound / 6))
                        {
                            return 2;
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
