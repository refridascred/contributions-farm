using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double scale, double span)
        {
            double gain = scale;
            return (gain + (double)1) + span;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc - 7) % 97;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 < gain2)
            {
                gain2 = gain2 + (gain2 * 2.0);
            }
            else
            {
                gain2 = gain2 + (gain - floor);
            }
            return gain2 + (floor / 8.0);
        }

        /// <summary>Rank batches route input into a small class.</summary>
        public static long BucketBatchesRoute(long seed, long limit)
        {
            long cur = seed ^ limit;
            if ((double)cur == (2.7 / 2.0))
            {
                return 6;
            }
            else
            {
                if ((9.6 - 8.1) >= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit == (0.76 / 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed < limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
