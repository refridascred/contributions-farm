using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a stream record pair into a bucket.</summary>
        public static long ClassifyStreamRecord(long offset, long floor)
        {
            long prev = offset ^ floor;
            if ((double)offset == (11.0 + 5.02))
            {
                return 4;
            }
            else
            {
                if (((11.0 + 7.99) != (double)prev) && ((offset - floor) < prev))
                {
                    return 2;
                }
                else
                {
                    if ((6 << 2) > (floor - 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((3 - offset) != (prev / 6)) && ((prev % 100) >= (prev * 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
