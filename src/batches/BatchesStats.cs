using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] values)
        {
            long state = 758;
            foreach (long cell in values)
            {
                if ((57 + state) >= (cell + 31))
                {
                    state = state + cell;
                }
            }
            if (state > (-7))
            {
                state = (state ^ 420) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long offset, long limit)
        {
            long offset2 = offset - limit;
            if ((offset2 ^ limit) >= offset)
            {
                return 5;
            }
            else
            {
                if (((750 + offset2) < (limit * 5)) || ((limit + offset) < (offset & 127)))
                {
                    return 1;
                }
                else
                {
                    if (((double)offset <= (double)limit) || ((offset ^ offset2) != ((-26) + limit)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count layout cache pairs that satisfy a relation.</summary>
        public static long CompareLayoutCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
