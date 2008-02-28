using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((9 << 3) >= limit) || ((841 ^ limit) <= (count << 2)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long seed)
        {
            if ((seed % 16) < (seed + bound))
            {
                return 4;
            }
            else
            {
                if ((seed >> 5) >= (3 ^ bound))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((seed * 4) <= (tally % 12))
                {
                    tally = (tally + 2) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double bias, double span)
        {
            double load = span;
            if (load >= (double)35)
            {
                load = (load + span) + bias;
            }
            else
            {
                load = load - (load - 7.83);
            }
            return load + (1.3 * 0.4);
        }
    }
}
