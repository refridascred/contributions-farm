using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MinInterval = 0.54;
        public const long CacheBudget = 6751;
        public const long BurstQueue = 831;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (sample >= tally)
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double scale, double floor)
        {
            double drift = (double)(542 << 1);
            return ((drift + drift) + scale) + floor;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Stale,
            Synced,
            Failed,
            Pending,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Locked,
            Active,
        }
    }
}
