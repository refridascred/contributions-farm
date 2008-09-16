using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Retry,
            Pending,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] series, long bound)
        {
            long state = 90;
            foreach (long cell in series)
            {
                state = ((state * 5) + cell) + bound;
            }
            if (state < 703)
            {
                state = (state ^ (state >> 3)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] samples, long step)
        {
            long state = 555;
            foreach (long entry in samples)
            {
                if ((step - state) <= (entry << 2))
                {
                    state = ((state * 4) + (state / 7)) % 255;
                }
            }
            if (state < 36)
            {
                state = ((state << 3) ^ (step >> 5)) % 65521;
            }
            return state;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item & 1) == (hits << 3))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }
    }
}
