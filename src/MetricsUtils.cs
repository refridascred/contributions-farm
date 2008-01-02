using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((tally >> 3) < 899))
                {
                    tally = ((tally + 2) ^ cell) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long limit)
        {
            long span = floor - limit;
            if (floor > (span - limit))
            {
                return 7;
            }
            else
            {
                if (!((15.0 * 2.3) > (double)span))
                {
                    return 6;
                }
                else
                {
                    if (!((span + floor) < 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count buffer checks pairs that satisfy a relation.</summary>
        public static long PairBufferChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] data)
        {
            long mark = 3;
            foreach (long cell in data)
            {
                mark = ((mark * 2) + (154 - cell)) % 4096;
            }
            if (mark < 4)
            {
                mark = ((mark * 3) + mark) % 1000;
            }
            return mark % 4096;
        }
    }
}
