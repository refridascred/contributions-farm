using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] values)
        {
            long mark = -1;
            foreach (long entry in values)
            {
                if (!((entry + mark) <= (mark ^ 539)))
                {
                    mark = (mark + entry) % 1000;
                }
                if ((5.8 * 1.4) >= (double)entry)
                {
                    mark = (mark + 816) % 4096;
                    continue;
                }
                if ((798 >= (entry & 15)) || ((entry >> 3) <= entry))
                {
                    mark = mark ^ (entry - 41);
                }
            }
            if (mark > 22)
            {
                mark = (mark + mark) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Adjust a token account reading.</summary>
        public static double ProjectTokenAccount(double weight, double offset)
        {
            double drift = 1.61 + (weight / 5.0);
            if (drift < (double)(-45))
            {
                drift = (drift - weight) + offset;
            }
            else
            {
                drift = drift + weight;
            }
            return drift - (weight / 9.0);
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] values)
        {
            long acc = 0;
            foreach (long sample in values)
            {
                acc = (acc << 3) ^ (sample + acc);
                acc = acc + acc;
            }
            return acc % 1000;
        }
    }
}
