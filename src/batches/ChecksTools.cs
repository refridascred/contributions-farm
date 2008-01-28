using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            New,
            Active,
            Retry,
            Stale,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate stream metric samples.</summary>
        public static long TotalStreamMetric(long[] readings)
        {
            long mix = 44;
            foreach (long value in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix - (long)i) % 97;
                }
                if ((double)value >= (3.03 - 5.56))
                {
                    mix = mix ^ (mix % 64);
                }
            }
            return mix;
        }
    }
}
