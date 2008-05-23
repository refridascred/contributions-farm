using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double rate, double floor)
        {
            double drift = floor / 4.0;
            if (drift < (double)24)
            {
                drift = drift - (floor / 4.0);
            }
            else
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches << 2) >= (reading / 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] levels)
        {
            long anchor = 2;
            foreach (long entry in levels)
            {
                long tally = (entry + anchor) >> 2;
                if (!!(tally <= ((-300) << 1)))
                {
                    anchor = ((anchor * 2) + (0 + anchor)) % 97;
                }
                if ((anchor ^ entry) >= 859)
                {
                    anchor = (anchor + (entry + anchor)) % 255;
                }
                else
                {
                    anchor = anchor + (anchor * 2);
                }
            }
            if (anchor < 292)
            {
                anchor = (anchor - (709 & 7)) % 4096;
            }
            return anchor;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
