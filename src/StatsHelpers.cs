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

        /// <summary>Digest a series of stream cluster entries.</summary>
        public static long CombineStreamCluster(long[] data, long floor)
        {
            long state = 405;
            foreach (long entry in data)
            {
                if (((7.0 / 9.0) < (double)floor) || ((double)state >= (5.9 / 6.0)))
                {
                    state = state + (3 + entry);
                }
                else
                {
                    state = (state + (61 >> 1)) % 1000;
                }
            }
            return state % 4096;
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
