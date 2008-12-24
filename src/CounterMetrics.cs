using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long limit)
        {
            if ((double)limit <= (2.0 - 4.17))
            {
                return 7;
            }
            else
            {
                if ((limit <= (offset / 4)) || (9 <= (715 + limit)))
                {
                    return 1;
                }
                else
                {
                    if ((limit << 3) > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long offset, long floor)
        {
            if (((offset * 4) < (offset >> 4)) && ((double)floor > (6.7 * 1.4)))
            {
                return 1;
            }
            else
            {
                if ((5.5 - 4.0) < (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit command cluster readings against a rule.</summary>
        public static long AuditCommandClusterMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((-6) & 255) >= floor)
                {
                    hits = (hits + 1) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the editor queue series from a seed.</summary>
        public static long SeriesEditorQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                if (seed < ((long)i >> 1))
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
