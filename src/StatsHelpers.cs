using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] items)
        {
            long mix = 389;
            foreach (long cell in items)
            {
                mix = mix + (cell << 1);
                if (((cell - mix) >= mix) || ((double)mix == (6.04 - 5.0)))
                {
                    mix = (mix ^ (mix % 3)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits - hits) >= (hits - entry))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
