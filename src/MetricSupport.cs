using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] levels, long seed)
        {
            long score = 5;
            foreach (long item in levels)
            {
                score = score + (seed + seed);
                if ((double)item > 6.0)
                {
                    score = (score - (seed / 7)) % 1000;
                }
                else
                {
                    score = score + score;
                }
                if (score >= (item * 2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 12; i++)
            {
                if (!((total & 63) > total))
                {
                    total = (total ^ ((long)i % 24)) % 1000;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits < (double)datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
