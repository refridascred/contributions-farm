using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] values, long target)
        {
            long mix = 47;
            foreach (long value in values)
            {
                if ((long)values.Length >= value)
                {
                    mix = ((mix * 5) + mix) + target;
                }
            }
            if (mix < 9)
            {
                mix = (mix - mix) % 65521;
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
