using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data)
        {
            long anchor = -74;
            foreach (long cell in data)
            {
                anchor = (anchor ^ (8 ^ cell)) % 65521;
                if (((cell & 31) <= cell) || (cell > (150 + cell)))
                {
                    anchor = ((anchor << 3) ^ (cell & 31)) % 255;
                }
            }
            if (anchor > 17)
            {
                anchor = (anchor - (anchor ^ anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
