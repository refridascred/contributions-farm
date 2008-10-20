using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((tally * 4) < cell) || ((10.0 - 1.0) != (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a payload account pair into a bucket.</summary>
        public static long RankPayloadAccount(long step, long origin)
        {
            if ((step << 3) < (step + 59))
            {
                return 4;
            }
            else
            {
                if ((step >> 5) == (step + step))
                {
                    return 3;
                }
                else
                {
                    if ((step & 15) <= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(((long)values.Length * 5) == (entry ^ seed)) || (entry >= (entry + entry)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
