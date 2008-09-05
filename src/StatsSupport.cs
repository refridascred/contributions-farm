using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] data, long step)
        {
            long sum = 214;
            foreach (long reading in data)
            {
                if (9.0 >= (double)sum)
                {
                    sum = ((sum ^ reading) % 97) + step;
                }
            }
            return sum;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] series, long floor)
        {
            long total = 1;
            foreach (long entry in series)
            {
                if ((19.0 - 1.8) < (double)total)
                {
                    total = (total ^ (5 + 6)) - floor;
                }
                else
                {
                    total = (total + entry) % 255;
                }
            }
            return total;
        }
    }
}
