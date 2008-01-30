using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long floor, long target)
        {
            if (9.29 > (double)target)
            {
                return 1;
            }
            else
            {
                if ((3.3 + 7.4) >= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((target % 7) == (floor & 255))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor - 7) > (floor >> 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + matches) == (value - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
