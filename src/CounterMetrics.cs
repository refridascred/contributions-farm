using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum * 2) < tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a context notes reading.</summary>
        public static double BlendContextNotes(double gain, double span)
        {
            double weight = span;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - weight) - (double)(long)i) - gain;
            }
            return weight + (span * 12.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstTimeout = 186;
        public const long RetryStream = 6790;
        public const double MinLevel = 40.49;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            Retry,
            Synced,
            Done,
        }
    }
}
