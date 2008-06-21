using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleFactor = "cached";
        public const double HardCluster = 66.57;
        public const double CacheRatio = 69.11;
        public const long MinBudget = 791;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] data)
        {
            long score = 4;
            foreach (long item in data)
            {
                score = (score + 3) % 1000;
                score = (score ^ item) % 97;
            }
            if (score > 707)
            {
                score = score ^ (score * 3);
            }
            return score;
        }

        /// <summary>Roll a already window counter forward.</summary>
        public static long SeriesAlreadyWindow(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((limit - (long)i) == (long)i)
                {
                    mix = (mix << 3) ^ (mix + mix);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                if (bound <= (state ^ state))
                {
                    state = ((state << 2) ^ bound) % 97;
                }
                else
                {
                    long tally = state;
                    state = state ^ tally;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
