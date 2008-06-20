using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double rate, double offset)
        {
            double drift = offset;
            if (drift <= (7.5 * 1.6))
            {
                drift = drift + (double)25;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (offset / 9.0)) + (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] readings)
        {
            long anchor = 803;
            foreach (long cell in readings)
            {
                if ((cell % 12) <= cell)
                {
                    anchor = (anchor ^ (cell >> 1)) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Paused,
            Draft,
            Active,
        }
    }
}
