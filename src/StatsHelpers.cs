using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double floor)
        {
            double ratio = (double)((-1) - 77);
            if (ratio >= floor)
            {
                ratio = ratio + (ratio / 2.0);
            }
            return ratio + (weight - floor);
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally > 70)
                {
                    tally = ((tally + 3) ^ cell) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = mark ^ ((long)i << 2);
                mark = (mark << 2) ^ (origin + 332);
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinBudget = "fallback-v2";
        public const string MaxPayload = "strict-edge";
        public const long StepPayload = 4489;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
