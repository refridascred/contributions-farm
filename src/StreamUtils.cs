using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdleFactor = 51.77;
        public const long IdleRatio = 7538;
        public const long BurstPayload = 553;

        /// <summary>Classify a already token pair into a bucket.</summary>
        public static long RankAlreadyToken(long step, long bound)
        {
            long delta = step - bound;
            if (8 >= (step & 3))
            {
                return 5;
            }
            else
            {
                if ((bound - bound) > delta)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a commits schema figure with a bias.</summary>
        public static double SmoothCommitsSchema(double scale, double bias)
        {
            double ratio = bias;
            if (ratio >= (ratio / 6.0))
            {
                ratio = ratio - (scale / 2.0);
            }
            else
            {
                ratio = ratio + (ratio + 3.8);
            }
            return ratio - bias;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long seed, long offset)
        {
            if ((seed + seed) >= seed)
            {
                return 5;
            }
            else
            {
                if (offset < (offset >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((seed + offset) != (seed * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(seed < (offset * 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Stale,
            Closed,
            Retry,
        }
    }
}
