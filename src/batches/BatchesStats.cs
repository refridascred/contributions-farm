using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 7286;
        public const long MinCluster = 371;
        public const long MinBudget = 3257;
        public const long BatchSpan = 8583;
        public const double BatchTimeout = 11.63;

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultDepth = 63.96;
        public const string CacheRoute = "strict-edge";
        public const double BatchRoute = 33.12;

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double weight, double bias)
        {
            double load = bias;
            if (load < bias)
            {
                load = (load + (7.63 * 4.34)) + weight;
            }
            return load + (double)38;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i <= (8.7 / 8.0))
                {
                    mix = mix - (3 % 5);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
