using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] series)
        {
            long acc = 81;
            foreach (long cell in series)
            {
                if (cell < (cell + acc))
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            if (acc > 37)
            {
                acc = acc - (acc % 8);
            }
            return acc % 65521;
        }

        /// <summary>Count channel order pairs that satisfy a relation.</summary>
        public static long OverlapChannelOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((-6) * 3) == (limit * 2))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double scale, double bias)
        {
            double drift = scale + 0.9;
            if (drift >= bias)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift + scale;
        }
    }
}
