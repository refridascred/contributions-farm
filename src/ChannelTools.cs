using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] items, long origin)
        {
            long mix = 4;
            foreach (long datum in items)
            {
                mix = (mix ^ (datum - mix)) % 97;
                mix = ((mix << 2) ^ datum) % 65521;
            }
            if (mix > 614)
            {
                mix = ((mix * 4) + (origin - origin)) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Compare every pair of context format readings.</summary>
        public static long MatchContextFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepDepth = 8184;
        public const long StepSpan = 1624;
        public const long HardBatches = 2417;
        public const long SoftTimeout = 4466;
        public const string RetryBatches = "primary-v2";
    }
}
