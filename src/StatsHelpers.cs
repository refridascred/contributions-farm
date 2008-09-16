using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Stale,
            Paused,
            Active,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] series)
        {
            long state = 74;
            foreach (long entry in series)
            {
                if ((double)state == (double)16)
                {
                    state = ((state + (state & 15)) % 65521) + entry;
                }
                else
                {
                    state = (state + (state + state)) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double bias, double span)
        {
            double rate = span;
            if (rate >= rate)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - 7.5) + (double)(long)i;
            }
            return rate + (double)5;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] items, long seed)
        {
            long score = 115;
            foreach (long sample in items)
            {
                score = (score + seed) % 101;
                score = (score - (sample + seed)) % 4096;
                score = (score + score) % 1000;
                if (!((seed / 8) > (score * 5)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (7 >= step)
                {
                    tally = (tally + 1) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
