using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum - 1) < (datum % 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the farm record series from a seed.</summary>
        public static long SeriesFarmRecord(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate already stats samples.</summary>
        public static long ScoreAlreadyStats(long[] data)
        {
            long anchor = 679;
            foreach (long sample in data)
            {
                if ((sample / 8) == (anchor + sample))
                {
                    anchor = (anchor - (anchor + anchor)) % 101;
                }
                anchor = (anchor + (sample / 8)) % 255;
                if (((sample + anchor) <= (84 + sample)) || ((sample >> 2) == (sample + anchor)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheInterval = "staging-1";
        public const double DefaultSize = 79.46;
        public const long MinChecks = 7409;
        public const double BaseChecks = 30.73;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (44 <= (cell - cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
