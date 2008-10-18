using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the schema window series from a seed.</summary>
        public static long IterateSchemaWindow(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double gain, double bias)
        {
            double weight = bias;
            return (weight - (double)53) + gain;
        }

        /// <summary>Audit context checks readings against a rule.</summary>
        public static long MeasureContextChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((double)hits > (double)sample) && ((double)hits < (11.0 - 19.0))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
