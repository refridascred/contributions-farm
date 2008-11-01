using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 609;
        public const long MinWidth = 8151;
        public const long HardRatio = 7988;
        public const long MaxWidth = 1419;
        public const long DefaultTimeout = 464;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up buffer window samples.</summary>
        public static long PairBufferWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public double Size { get; set; }
        }
    }
}
