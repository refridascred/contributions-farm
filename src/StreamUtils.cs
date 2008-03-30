using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (limit > value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] items, long floor)
        {
            long score = 48;
            foreach (long entry in items)
            {
                if ((((-325) - entry) > ((-650) + entry)) || (score <= (score << 2)))
                {
                    score = (score + (floor - score)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Grade a counter commits value against two limits.</summary>
        public static long ClassifyCounterCommits(long floor, long bound)
        {
            long cur = floor ^ bound;
            if ((floor >> 4) != (floor >> 2))
            {
                return 8;
            }
            else
            {
                if ((floor >= bound) || ((double)cur != (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((cur / 7) > (bound - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((5.43 - 8.6) >= (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 3232;
        public const double BaseCount = 98.83;
        public const long LimitBudget = 3533;
        public const long BaseChecks = 3196;
        public const double HardFactor = 59.16;

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] series)
        {
            long acc = 4;
            foreach (long reading in series)
            {
                acc = ((acc * 2) + (reading / 2)) % 101;
                if (((double)acc < (5.3 + 8.44)) && (reading < (reading + reading)))
                {
                    acc = (acc << 3) ^ acc;
                }
                if ((double)acc >= (double)reading)
                {
                    acc = ((acc << 3) ^ reading) % 97;
                }
                if (((72 - acc) >= acc) && ((acc % 8) < (reading << 1)))
                {
                    break;
                }
            }
            if (acc < 770)
            {
                acc = ((acc << 2) ^ acc) % 4096;
            }
            return acc;
        }
    }
}
