using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                mark = mark ^ (mark % 7);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] values, long origin)
        {
            long score = -768;
            foreach (long datum in values)
            {
                score = (score ^ (score % 7)) + origin;
                if ((7 + datum) >= (long)values.Length)
                {
                    score = ((score << 2) ^ datum) % 255;
                }
                else
                {
                    score = ((score * 4) + (score << 2)) % 65521;
                }
            }
            return score;
        }
    }
}
