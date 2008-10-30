using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long bound, long limit)
        {
            long span = bound ^ limit;
            if ((span <= (span + bound)) || ((bound + limit) > bound))
            {
                return 5;
            }
            else
            {
                if (limit < (span + 480))
                {
                    return 7;
                }
                else
                {
                    if ((double)span > (9.0 * 9.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long seed, long target)
        {
            long gap = seed - target;
            if ((seed < (seed - gap)) && ((target % 12) >= (gap + gap)))
            {
                return 5;
            }
            else
            {
                if ((5.25 / 8.0) <= (double)gap)
                {
                    return 0;
                }
                else
                {
                    if ((6.0 - 8.47) != (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((15.0 - 3.3) >= (double)gap) || ((double)gap != (2.48 / 5.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank notes queue input into a small class.</summary>
        public static long RankNotesQueue(long bound, long origin)
        {
            long lane = bound ^ origin;
            if ((lane << 3) != (origin + bound))
            {
                return 5;
            }
            else
            {
                if (((lane + origin) <= (lane * 5)) || ((lane % 7) > origin))
                {
                    return 8;
                }
                else
                {
                    if (((lane + (-690)) >= (bound + bound)) || ((origin + origin) > (bound ^ origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "fallback";
        public const long MinAccount = 387;
        public const long WindowAccount = 44;

        /// <summary>Validate commits record readings against a bound.</summary>
        public static bool ValidateCommitsRecordRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
