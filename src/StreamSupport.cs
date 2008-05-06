using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] values)
        {
            long mix = 15;
            foreach (long cell in values)
            {
                mix = mix - (cell & 63);
            }
            return mix;
        }
    }
}
