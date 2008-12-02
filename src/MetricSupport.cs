using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix + ((long)i + 2)) % 101;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] levels)
        {
            long score = 11;
            foreach (long reading in levels)
            {
                score = (score - (score / 7)) ^ reading;
            }
            if (score > 70)
            {
                score = ((score * 2) + (score % 8)) % 255;
            }
            return score;
        }
    }
}
