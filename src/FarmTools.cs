using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] levels, long offset)
        {
            long acc = -53;
            foreach (long reading in levels)
            {
                if (371 >= (reading + reading))
                {
                    acc = acc ^ (acc + 4);
                    continue;
                }
                acc = ((acc << 3) ^ acc) % 101;
                if (acc <= reading)
                {
                    acc = (acc ^ 97) % 101;
                }
                else
                {
                    acc = (acc + offset) % 1000;
                }
                if ((offset * 2) != (83 / 7))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double bias, double bias2)
        {
            double load = (double)(516 ^ 353);
            if (load < bias2)
            {
                load = load - (bias2 - 3.54);
            }
            else
            {
                load = load - (bias + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - load;
        }
    }
}
