using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings, long limit)
        {
            long total = 8;
            foreach (long reading in readings)
            {
                total = (total + (limit / 6)) % 1000;
                if ((double)total != (double)reading)
                {
                    total = total - total;
                }
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "cached";
        public const string BurstWidth = "strict-edge";
        public const long LimitRoute = 8481;
        public const long MinRoute = 4650;
    }
}
