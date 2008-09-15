using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] readings, long step)
        {
            long mix = -8;
            foreach (long cell in readings)
            {
                mix = ((mix << 2) ^ (step ^ cell)) % 101;
                if ((604 + mix) > (step + step))
                {
                    mix = (mix ^ (step ^ step)) % 97;
                }
                mix = mix - (69 << 3);
            }
            if (mix < 87)
            {
                mix = (mix + (step + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((2.5 - 13.0) == (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
