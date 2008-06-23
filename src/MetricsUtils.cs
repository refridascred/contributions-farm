using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long seed, long step)
        {
            long offset = seed ^ step;
            if ((5.85 + 2.6) == (double)step)
            {
                return 0;
            }
            else
            {
                if (seed < (seed << 2))
                {
                    return 3;
                }
                else
                {
                    if (!(offset < (step & 255)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed + 894) >= step) && ((double)1 >= (double)step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
