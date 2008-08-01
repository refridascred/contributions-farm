using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((entry * 4) < count) || ((double)count != (12.0 * 3.7)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] series)
        {
            long total = -41;
            foreach (long datum in series)
            {
                total = ((total << 2) ^ datum) % 1000;
                if ((datum * 4) < (920 + datum))
                {
                    total = total ^ (datum - datum);
                }
                else
                {
                    total = (total * 3) + (datum >> 1);
                }
            }
            if (total < 2)
            {
                total = total + (total + total);
            }
            return total % 65521;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally < (6.7 + 3.08))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
