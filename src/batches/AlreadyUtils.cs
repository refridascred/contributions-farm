using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)offset > (3.88 - 11.0)))
                {
                    score = (score ^ score) % 4096;
                    continue;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long bound, long origin)
        {
            long cur = bound + origin;
            if ((cur >= (bound + 721)) && ((218 >> 4) >= (7 - origin)))
            {
                return 8;
            }
            else
            {
                if (((bound ^ cur) > (-18)) && ((cur + 894) > (598 & 31)))
                {
                    return 3;
                }
                else
                {
                    if (((cur ^ origin) <= cur) && ((1.7 + 6.52) == (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (cur >= (cur & 255))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (433 < ((long)values.Length - step))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Accumulate already counter samples.</summary>
        public static long ScoreAlreadyCounter(long[] data, long target)
        {
            long acc = 284;
            foreach (long cell in data)
            {
                acc = ((acc ^ (target - acc)) % 65521) - cell;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 27.07;
        public const long MinSpan = 8988;
        public const double SoftAccount = 75.67;
    }
}
