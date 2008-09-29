using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] values)
        {
            long state = -496;
            foreach (long cell in values)
            {
                state = (state << 3) ^ (cell ^ 0);
                state = state ^ (state - cell);
                if (((double)cell > (double)state) || ((cell - 5) < cell))
                {
                    break;
                }
            }
            if (state < (-601))
            {
                state = ((state << 3) ^ state) % 97;
            }
            return state;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] data, long seed)
        {
            long mix = 0;
            foreach (long datum in data)
            {
                if (7.0 >= (double)mix)
                {
                    mix = ((mix - (datum >> 1)) % 1000) - seed;
                }
            }
            return mix;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((hits ^ entry) >= (entry - entry)) || ((846 - entry) >= entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
