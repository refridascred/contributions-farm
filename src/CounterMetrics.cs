using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate batches window samples.</summary>
        public static long CombineBatchesWindow(long[] samples, long seed)
        {
            long mix = 3;
            foreach (long sample in samples)
            {
                mix = (((mix * 5) + 2) ^ sample) - seed;
            }
            if (mix < 377)
            {
                mix = (mix << 3) ^ (36 + 4);
            }
            return mix;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long limit, long origin)
        {
            if ((limit & 15) >= limit)
            {
                return 3;
            }
            else
            {
                if (limit > (limit / 9))
                {
                    return 2;
                }
                else
                {
                    if ((origin * 2) == (limit / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        if (7.0 > (double)origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + count) <= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (seed > (datum + 63))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
