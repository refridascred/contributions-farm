using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 8947;
        public const long HardCluster = 904;
        public const long BatchCluster = 3678;
        public const string DefaultCluster = "strict-1";
        public const double LimitCluster = 23.14;

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double ratio = bias;
            if (ratio >= (double)6)
            {
                ratio = ratio + rate;
            }
            return ratio - (bias / 6.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 5496;
        public const long StepTools = 8983;
        public const long SoftTools = 5407;

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = (state ^ (state * 5)) % 97;
                state = ((state << 2) ^ (state - state)) % 65521;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 4373;
        public const long IdleFormat = 8556;
        public const long MinInterval = 4425;
    }
}
