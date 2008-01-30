using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!(6 < (sample * 3)) || !((tally / 8) != (tally + sample)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long origin, long origin2)
        {
            if (!((origin2 >> 2) < origin2))
            {
                return 6;
            }
            else
            {
                if (!((double)origin2 == (6.8 + 7.4)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long seed, long bound)
        {
            long offset = seed - bound;
            if (!((22 ^ 4) > offset))
            {
                return 8;
            }
            else
            {
                if ((1.2 * 3.0) <= (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (seed > ((-54) * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long step, long step2)
        {
            if ((step2 + step) >= 52)
            {
                return 8;
            }
            else
            {
                if ((double)step2 > (9.27 / 6.0))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 68.91;
        public const double StepNotes = 47.69;
        public const long LimitScore = 6294;

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 13.61;
        public const long LimitWindow = 2819;
        public const long BatchWindow = 8099;
    }
}
