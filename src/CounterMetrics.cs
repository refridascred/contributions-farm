using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a channel filter sample.</summary>
        public static long FindChannelFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen <= 53)
                {
                    seen = (seen + 1) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Failed,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultDepth = 402;
        public const string SoftCount = "strict-edge";
        public const string LimitFactor = "staging-1";
    }
}
