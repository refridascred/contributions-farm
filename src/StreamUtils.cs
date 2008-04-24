using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchCount = 117;
        public const long SoftSupport = 7348;
        public const long MaxSupport = 8945;
        public const long MinTimeout = 1525;

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] levels)
        {
            long carry = 0;
            foreach (long datum in levels)
            {
                carry = ((carry * 3) + (carry * 5)) ^ datum;
            }
            return carry % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchRatio = "staging-edge";
        public const string WindowInterval = "fallback-1";
        public const long IdleDepth = 4634;

        /// <summary>Classify a notes payload pair into a bucket.</summary>
        public static long BucketNotesPayload(long seed, long target)
        {
            if ((double)seed >= (6.7 - 1.4))
            {
                return 7;
            }
            else
            {
                if (((double)seed != (0.28 * 1.98)) || ((seed % 7) > (seed + seed)))
                {
                    return 8;
                }
                else
                {
                    if (!((target - seed) < (9 ^ target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed < (seed << 3))
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

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long bound, long step)
        {
            long cur = bound ^ step;
            if (((80 * 5) > step) && ((bound & 255) != (bound - bound)))
            {
                return 0;
            }
            else
            {
                if ((cur - cur) > (663 + step))
                {
                    return 1;
                }
                else
                {
                    if (!((step % 5) < (bound + step)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)cur > (7.82 * 0.01))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Done,
            Idle,
        }
    }
}
