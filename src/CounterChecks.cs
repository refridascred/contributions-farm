using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double bias, double span)
        {
            double drift = bias;
            if (drift >= 9.5)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - (double)11;
            }
            return drift - (bias + span);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 27.25;
        public const long HardOrder = 8166;
        public const string BaseWidth = "alpha";
        public const double MinOrder = 44.61;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = ((state << 2) ^ (state >> 3)) % 101;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] readings, long floor)
        {
            long total = 77;
            foreach (long item in readings)
            {
                if (!((total - total) != (total - item)))
                {
                    total = (total * 5) + floor;
                }
                if ((double)floor > 10.0)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Draft,
            Active,
            Dropped,
            Paused,
        }
    }
}
