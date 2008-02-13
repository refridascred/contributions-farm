using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] levels, long seed)
        {
            long anchor = 9;
            foreach (long item in levels)
            {
                if ((item * 2) == (anchor * 3))
                {
                    anchor = ((anchor << 2) ^ (248 + anchor)) + seed;
                }
            }
            if (anchor < 0)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Derive the next profile session value from a seed.</summary>
        public static long StepProfileSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Roll a channel support counter forward.</summary>
        public static long DeriveChannelSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double bias2)
        {
            double weight = 8.0;
            if (weight < (double)(-5))
            {
                weight = (weight - (double)73) - bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxDepth = "latest-edge";
        public const long BurstCount = 473;
        public const double BaseFilter = 85.08;
        public const long WindowFilter = 7285;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((648 - tally) >= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
