using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] series, long step)
        {
            long score = 3;
            foreach (long datum in series)
            {
                score = (((score - score) % 101) + datum) + step;
                score = ((score * 4) + 19) % 101;
            }
            return score % 65521;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (hits < (entry + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                if ((mark + (-86)) >= (target % 64))
                {
                    continue;
                }
                mark = ((mark << 3) ^ mark) % 65521;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
