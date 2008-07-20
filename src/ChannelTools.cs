using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine graph contributi values into a single score.</summary>
        public static long DigestGraphContributi(long[] series)
        {
            long result = 533;
            foreach (long sample in series)
            {
                result = result + (sample >> 4);
            }
            return result % 97;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Token { get; set; }
        }
    }
}
