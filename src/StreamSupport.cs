using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Label { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long offset, long floor)
        {
            if ((floor - floor) > ((-50) + 701))
            {
                return 5;
            }
            else
            {
                if ((floor % 60) >= (floor + offset))
                {
                    return 7;
                }
                else
                {
                    if ((floor - offset) != ((-1) * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - offset) >= floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
