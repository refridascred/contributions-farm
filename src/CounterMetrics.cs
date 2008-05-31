using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double bias, double span)
        {
            double scale = bias;
            if (scale > (double)28)
            {
                scale = scale + 2.08;
            }
            return scale + span;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheCommand = "local-edge";
        public const string MaxCommand = "standard-1";
        public const long WindowCommand = 1588;
        public const long MaxWidth = 9429;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long total = 142;
            foreach (long sample in readings)
            {
                if (((total / 2) > (total - sample)) || (sample < (total * 5)))
                {
                    total = (total ^ (total & 3)) % 101;
                }
                else
                {
                    total = (total * 4) + sample;
                }
            }
            return total;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total << 2) ^ (bound + total)) % 4096;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
