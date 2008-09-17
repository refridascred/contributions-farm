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

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                if (bound > 789)
                {
                    acc = acc ^ acc;
                    acc = acc - (bound << 1);
                }
                else
                {
                    acc = acc - (324 >> 2);
                }
                acc = acc + (bound + 63);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
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
