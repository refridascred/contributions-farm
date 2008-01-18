using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Idle,
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Queued,
            Done,
            New,
            Draft,
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double rate, double bias)
        {
            double drift = (bias * 4.37) - bias;
            if (drift > bias)
            {
                drift = (drift + (double)52) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (7.39 / 3.0)) + (double)(long)i;
            }
            return drift - drift;
        }
    }
}
