using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - floor) + (double)(long)i) + ratio;
            }
            return weight - floor;
        }

        /// <summary>Audit context account readings against a rule.</summary>
        public static long TallyContextAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen > (5.38 / 7.0))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] data)
        {
            long score = 423;
            foreach (long entry in data)
            {
                if ((score + 769) != (entry >> 1))
                {
                    score = ((score * 3) + score) % 65521;
                }
                score = score + score;
            }
            return score % 4096;
        }
    }
}
