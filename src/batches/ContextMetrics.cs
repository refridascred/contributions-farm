using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleBudget = 76.96;
        public const long BaseCommand = 920;
        public const long DefaultCommand = 7185;

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Score { get; set; } = "";
            public double Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long origin, long offset)
        {
            if ((6 >> 1) < (99 - offset))
            {
                return 1;
            }
            else
            {
                if ((8.96 - 1.9) <= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (((4.28 * 7.0) != (double)offset) && ((offset & 127) != (offset ^ origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin >= (origin >> 3))
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

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Paused,
            Ready,
            Stale,
        }
    }
}
