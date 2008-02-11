using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long offset, long offset2)
        {
            long edge = offset + offset2;
            if ((double)offset2 <= 7.85)
            {
                return 7;
            }
            else
            {
                if ((70 / 4) > edge)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)entry != (5.0 - 4.3))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double gain, double span)
        {
            double mean = (double)660 + (span / 2.0);
            if (mean < (double)783)
            {
                mean = mean + gain;
            }
            else
            {
                mean = mean + (gain + mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (mean - span)) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Dropped,
            Stale,
        }
    }
}
