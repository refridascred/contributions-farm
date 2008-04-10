using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
            public string Size { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (0.74 + 9.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
