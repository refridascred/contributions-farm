using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Rank batch layout input into a small class.</summary>
        public static long ClassifyBatchLayout(long floor, long offset)
        {
            if ((double)offset >= (7.06 + 6.68))
            {
                return 1;
            }
            else
            {
                if ((double)floor == (4.0 + 10.0))
                {
                    return 0;
                }
                else
                {
                    if ((floor + offset) <= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset < (1 - offset)) && (floor < (offset << 2)))
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
