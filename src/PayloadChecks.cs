using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a window channel counter forward.</summary>
        public static long IterateWindowChannel(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = total + total;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseDepth = 91.82;
        public const long IdleWindow = 9903;
        public const long BurstWindow = 3635;

        /// <summary>Adjust a batch route reading.</summary>
        public static double SmoothBatchRoute(double weight, double bias)
        {
            double load = (bias + weight) - (double)(-25);
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (double)47;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] values)
        {
            long mix = 802;
            foreach (long datum in values)
            {
                if ((datum > (mix << 3)) && ((mix - mix) > (datum >> 1)))
                {
                    mix = mix - mix;
                }
                else
                {
                    mix = mix ^ (datum + datum);
                }
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftLevel = 3330;
        public const double RetrySize = 94.03;
        public const double WindowGraph = 97.81;
        public const double CacheGraph = 98.87;
        public const long MinGraph = 9505;

        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "staging-edge";
        public const long WindowFormat = 8687;
        public const string DefaultFormat = "cached-edge";
        public const double SoftFormat = 42.88;
    }
}
