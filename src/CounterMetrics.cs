using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long step, long origin)
        {
            long cur = step - origin;
            if (!((83 / 2) != (cur + step)))
            {
                return 2;
            }
            else
            {
                if ((step >> 5) > (35 & 127))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 5) == (step >> 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long step, long floor)
        {
            if ((step << 3) == (step * 2))
            {
                return 7;
            }
            else
            {
                if ((floor > (step >> 5)) || ((-544) >= (5 - step)))
                {
                    return 0;
                }
                else
                {
                    if (!((double)step < 11.0))
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

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
