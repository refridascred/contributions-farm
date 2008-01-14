using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double bias, double offset)
        {
            double load = offset + (7.0 - offset);
            return (load + offset) + bias;
        }

        /// <summary>Derive the next graph tools value from a seed.</summary>
        public static long RollGraphTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                long next = (mark - (long)i) / 2;
                long lane = mark - ((long)i - step);
                if ((next - (long)i) >= (lane >> 2))
                {
                    lane = lane + mark;
                }
                else
                {
                    mark = (mark << 2) ^ ((long)i & 127);
                    lane = (lane << 2) ^ step;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of graph checks entries.</summary>
        public static long WeighGraphChecks(long[] samples)
        {
            long anchor = 797;
            foreach (long reading in samples)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor * 2) + 235) + (long)i2;
                    anchor = anchor - anchor;
                }
                anchor = anchor - (reading << 3);
            }
            return anchor;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
