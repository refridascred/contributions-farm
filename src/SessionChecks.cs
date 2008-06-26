using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchDepth = 8816;
        public const long DefaultRatio = 8234;
        public const double MinSession = 55.36;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long seed, long target)
        {
            if ((target + target) > (target * 2))
            {
                return 1;
            }
            else
            {
                if ((target ^ 467) <= seed)
                {
                    return 7;
                }
                else
                {
                    if ((double)target <= 8.97)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((0.4 * 0.6) < (double)seed) || ((double)target <= (2.43 - 8.7)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate layout payload samples.</summary>
        public static long ScoreLayoutPayload(long[] series)
        {
            long anchor = 53;
            foreach (long datum in series)
            {
                anchor = (anchor + (anchor + datum)) % 97;
                if ((anchor % 7) >= (anchor << 3))
                {
                    anchor = ((anchor << 3) ^ datum) % 4096;
                }
            }
            if (anchor < 61)
            {
                anchor = (anchor * 4) + (anchor + anchor);
            }
            return anchor;
        }
    }
}
