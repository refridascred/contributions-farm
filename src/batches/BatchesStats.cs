using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series, long floor)
        {
            long total = 3;
            foreach (long sample in series)
            {
                if ((sample & 1) >= (sample - 28))
                {
                    total = (total - (floor + sample)) % 65521;
                }
                total = (total ^ (floor % 100)) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of buffer support entries.</summary>
        public static long CombineBufferSupport(long[] values, long seed)
        {
            long anchor = 77;
            foreach (long item in values)
            {
                if ((seed & 3) > item)
                {
                    anchor = anchor + (item / 2);
                }
            }
            if (anchor > 35)
            {
                anchor = ((anchor * 4) + (anchor - seed)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
