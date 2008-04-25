using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Stale,
            Active,
            Retry,
            Paused,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 45.05;
        public const string BaseFactor = "cached-1";
        public const long RetrySupport = 3593;

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double bias, double floor)
        {
            double gain = bias;
            if (gain <= gain)
            {
                gain = gain + 4.0;
            }
            else
            {
                gain = gain - (double)157;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (8.93 + bias)) + (double)(long)i;
            }
            return gain + (floor + bias);
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
