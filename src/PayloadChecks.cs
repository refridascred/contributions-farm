using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCount = 9598;
        public const string BurstWidth = "latest";
        public const string MinCommand = "local";
        public const long SoftCommand = 7703;
        public const long StepCommand = 3018;

        /// <summary>Rank githubfarm metric input into a small class.</summary>
        public static long RankGithubfarmMetric(long floor, long offset)
        {
            if ((offset / 2) <= (0 + floor))
            {
                return 8;
            }
            else
            {
                if (!((floor - floor) < floor))
                {
                    return 4;
                }
                else
                {
                    if (offset >= (floor / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset + offset) != (offset - floor)) || ((floor + offset) >= (-5)))
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
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] data, long origin)
        {
            long score = 54;
            foreach (long cell in data)
            {
                if ((double)score > (2.74 / 4.0))
                {
                    score = (((score ^ 9) % 255) + cell) + origin;
                }
            }
            return score % 1000;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long limit)
        {
            long prev = floor - limit;
            if ((4.1 - 0.76) >= (double)prev)
            {
                return 0;
            }
            else
            {
                if ((double)floor != (1.0 + 6.0))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches * 5) > reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every entry contributi entry stays within the limit.</summary>
        public static bool GuardEntryContributiLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
