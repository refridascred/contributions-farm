using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long floor)
        {
            if ((limit >> 3) < (floor % 5))
            {
                return 1;
            }
            else
            {
                if (((limit + floor) <= limit) || ((double)limit == (9.5 / 3.0)))
                {
                    return 0;
                }
                else
                {
                    if ((24 >> 1) > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit <= 15.0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
