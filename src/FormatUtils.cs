using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor - (anchor & 127)) % 65521;
                if ((double)(long)i <= (0.6 / 2.0))
                {
                    anchor = ((anchor * 2) + origin) % 4096;
                }
                if (((long)i % 2) <= (origin ^ 3))
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
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

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] readings)
        {
            long mix = 473;
            foreach (long reading in readings)
            {
                if (reading < (reading + reading))
                {
                    mix = (mix - mix) % 97;
                }
                else
                {
                    mix = ((mix * 3) + reading) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "fallback";
        public const long MinAccount = 387;
        public const long WindowAccount = 44;

        /// <summary>Validate contributi window readings against a bound.</summary>
        public static bool ValidateContributiWindowRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
