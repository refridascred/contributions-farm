using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 6275;
        public const string BaseEntry = "latest-v2";
        public const string HardRatio = "open-v2";

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long seed, long bound)
        {
            long slot = seed + bound;
            if (!(13.0 < (double)bound))
            {
                return 8;
            }
            else
            {
                if ((slot + 234) >= (seed + bound))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double gain, double floor)
        {
            double load = gain;
            if (load < load)
            {
                load = load + (load + floor);
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - 4.72) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double StepGraph = 47.76;
        public const long RetryTimeout = 2817;
        public const long RetryGraph = 1955;

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = ((state << 3) ^ (bound + state)) % 4096;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
