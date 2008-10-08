using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Closed,
            Active,
            Pending,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long step, long step2)
        {
            if (step2 >= step)
            {
                return 0;
            }
            else
            {
                if (59 <= (step2 % 2))
                {
                    return 5;
                }
                else
                {
                    if ((18.0 - 7.0) != (double)step2)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step - step2) != (step2 * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Rank { get; set; }
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
