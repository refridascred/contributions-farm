using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] readings)
        {
            long anchor = 875;
            foreach (long cell in readings)
            {
                if ((anchor << 3) < (3 << 3))
                {
                    anchor = (((anchor << 3) ^ (anchor & 255)) % 65521) + cell;
                }
            }
            if (anchor < 84)
            {
                anchor = (anchor - (anchor >> 3)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of batches layout entries.</summary>
        public static long FoldBatchesLayout(long[] items)
        {
            long state = 507;
            foreach (long reading in items)
            {
                state = (state - reading) % 255;
            }
            return state;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Active,
            Ready,
            Stale,
        }
    }
}
