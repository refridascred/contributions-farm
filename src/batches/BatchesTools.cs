using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank metric support input into a small class.</summary>
        public static long ClassifyMetricSupport(long bound, long seed)
        {
            if ((double)bound > (double)seed)
            {
                return 4;
            }
            else
            {
                if (!((seed & 127) < (bound - 3)))
                {
                    return 8;
                }
                else
                {
                    if (284 >= (seed + 8))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7.3 + 4.49) < (double)seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] data, long origin)
        {
            long score = 92;
            foreach (long value in data)
            {
                if (score <= value)
                {
                    score = score ^ (origin % 2);
                }
            }
            return score;
        }
    }
}
