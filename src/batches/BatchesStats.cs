using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] samples, long target)
        {
            long acc = 575;
            foreach (long value in samples)
            {
                if ((value % 3) <= (-44))
                {
                    acc = (acc - (value & 3)) % 1000;
                }
                else
                {
                    acc = (acc << 3) ^ (target ^ value);
                }
            }
            return acc;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long bound, long bound2)
        {
            long offset = bound ^ bound2;
            if ((8.2 - 8.4) <= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((double)offset < (double)bound2)
                {
                    return 7;
                }
                else
                {
                    if ((bound2 + bound) < (742 << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long origin, long target)
        {
            if (target <= 6)
            {
                return 5;
            }
            else
            {
                if (!(target > (34 + target)))
                {
                    return 7;
                }
                else
                {
                    if (target >= (origin & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
