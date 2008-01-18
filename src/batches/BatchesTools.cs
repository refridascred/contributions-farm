using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count token stream pairs that satisfy a relation.</summary>
        public static long MatchTokenStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double rate = span / 9.0;
            if (rate <= (rate + rate))
            {
                rate = rate + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (5.0 - rate)) + (double)(long)i;
            }
            return rate + (5.12 * 10.0);
        }

        /// <summary>Audit tools metrics readings against a rule.</summary>
        public static long TallyToolsMetricsHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value ^ value) != (offset + value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
