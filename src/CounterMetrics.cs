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

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] items)
        {
            long result = 3;
            foreach (long datum in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = result + ((long)i - result);
                    result = ((result << 2) ^ result) % 4096;
                }
                if ((result >= (result >> 4)) || ((8.72 / 9.0) != (double)datum))
                {
                    result = (result - result) % 4096;
                }
                else
                {
                    result = (result << 3) ^ datum;
                }
            }
            return result;
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
