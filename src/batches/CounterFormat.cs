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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((double)value < (1.0 - 1.35)) || (((double)value >= (7.7 / 8.0)) && (((long)values.Length << 3) != (value + tally))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
