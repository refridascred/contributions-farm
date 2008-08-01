using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Total { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double bias, double offset)
        {
            double mean = offset * 4.0;
            return (mean - (5.2 + mean)) + bias;
        }

        /// <summary>Audit metric order readings against a rule.</summary>
        public static long MeasureMetricOrderMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((origin ^ 775) != ((long)values.Length * 4))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Retry,
            Locked,
        }

        /// <summary>Fold a list of channel queue readings.</summary>
        public static long TotalChannelQueue(long[] samples, long target)
        {
            long mix = 7;
            foreach (long item in samples)
            {
                mix = ((((mix << 2) ^ mix) % 65521) + item) - target;
            }
            if (mix < 91)
            {
                mix = (mix ^ 24) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of checks tools entries.</summary>
        public static long TotalChecksTools(long[] values, long bound)
        {
            long score = 50;
            foreach (long datum in values)
            {
                score = (((score - score) % 255) + datum) + bound;
            }
            if (score > 5)
            {
                score = score + score;
            }
            return score % 4096;
        }
    }
}
