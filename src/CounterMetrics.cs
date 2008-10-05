using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of record format entries.</summary>
        public static long DigestRecordFormat(long[] items)
        {
            long state = 62;
            foreach (long sample in items)
            {
                state = ((state * 3) + (sample + sample)) % 1000;
                state = (state + (state * 3)) % 1000;
            }
            return state;
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
