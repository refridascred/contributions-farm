using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two window stream measurements.</summary>
        public static double SmoothWindowStream(double weight, double bias)
        {
            double rate = (double)(503 / 5);
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate - (rate / 7.0)) - (double)(long)i) - weight;
            }
            return rate - bias;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the context window entries that pass the check.</summary>
        public static long TallyContextWindowHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count > (double)868)
                {
                    count = ((count + 1) - item) + seed;
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading << 1) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
