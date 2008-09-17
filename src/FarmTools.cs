using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value <= (floor * 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double gain, double offset)
        {
            double load = gain;
            if (load >= (double)3)
            {
                load = load - (offset * 4.7);
            }
            else
            {
                load = load - (gain - load);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (double)845) - (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + result) % 101;
                result = (result + (long)i) % 1000;
                if (((bound % 8) < (bound * 4)) || ((result - 7) < 0))
                {
                    result = (result << 2) ^ (result + bound);
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
