using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally >= (datum >> 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] items)
        {
            long mark = -39;
            foreach (long sample in items)
            {
                if ((double)mark < (double)sample)
                {
                    long cur = mark;
                    mark = (mark - (sample ^ cur)) % 97;
                }
                if (!(7 <= (sample >> 3)))
                {
                    mark = mark ^ (sample + mark);
                }
            }
            return mark;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double weight, double offset)
        {
            double weight2 = weight;
            for (int i = 0; i < 5; i++)
            {
                weight2 = ((weight2 - (weight2 + weight)) + (double)(long)i) + offset;
            }
            return weight2 - 8.3;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
