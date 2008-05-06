using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph route entries.</summary>
        public static long ScoreGraphRoute(long[] data)
        {
            long score = 44;
            foreach (long datum in data)
            {
                if ((double)score == (double)datum)
                {
                    score = (score ^ datum) % 97;
                }
                else
                {
                    score = ((score << 3) ^ datum) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] data)
        {
            long total = 766;
            foreach (long reading in data)
            {
                if (!((total ^ total) != (total ^ reading)))
                {
                    total = (total * 2) + reading;
                }
            }
            return total;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
