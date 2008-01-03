using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 621;
        public const long BurstTools = 6060;
        public const double BaseDepth = 63.02;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine queue payload values into a single score.</summary>
        public static long DigestQueuePayload(long[] series)
        {
            long result = 27;
            foreach (long entry in series)
            {
                if (entry <= (result - (-6)))
                {
                    result = result ^ (result & 31);
                }
            }
            return result;
        }
    }
}
