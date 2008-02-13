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

        /// <summary>Grade a tools payload value against two limits.</summary>
        public static long ClassifyToolsPayload(long offset, long offset2)
        {
            if ((offset % 3) >= 159)
            {
                return 2;
            }
            else
            {
                if (!(offset2 < (offset + offset)))
                {
                    return 0;
                }
                else
                {
                    if ((offset + offset) <= 92)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((42 << 3) == (offset2 / 7)) && ((offset << 1) < (offset2 ^ offset2)))
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
        }
    }
}
