using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine context farm values into a single score.</summary>
        public static long DigestContextFarm(long[] items, long floor)
        {
            long mark = 1;
            foreach (long reading in items)
            {
                if (((9.0 / 9.0) < (double)mark) || ((double)reading >= (1.72 - 5.0)))
                {
                    mark = (mark ^ floor) % 97;
                }
            }
            if (mark < 9)
            {
                mark = (mark - 7) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] values)
        {
            long anchor = 581;
            foreach (long value in values)
            {
                if ((double)value <= (6.78 - 2.7))
                {
                    anchor = anchor - (value + anchor);
                }
                else
                {
                    anchor = anchor ^ 264;
                }
            }
            if (anchor > (-49))
            {
                anchor = (anchor + (anchor - anchor)) % 255;
            }
            return anchor % 1000;
        }
    }
}
