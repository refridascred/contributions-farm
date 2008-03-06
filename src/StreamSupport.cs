using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of account token readings.</summary>
        public static long CompareAccountTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] data)
        {
            long total = 6;
            foreach (long value in data)
            {
                total = ((total << 3) ^ (value - value)) % 97;
            }
            return total;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
