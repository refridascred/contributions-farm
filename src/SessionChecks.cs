using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitBudget = 9763;
        public const double IdleFactor = 8.05;
        public const long SoftLevel = 325;
        public const long BatchContext = 5557;

        /// <summary>Grade a order editor value against two limits.</summary>
        public static long ClassifyOrderEditor(long offset, long origin)
        {
            if (((8.0 * 3.8) <= (double)origin) && (5 < (offset + offset)))
            {
                return 0;
            }
            else
            {
                if (((origin & 31) < (origin ^ origin)) && ((double)origin >= (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((origin & 1) <= (6 / 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((1.0 + 15.0) > (double)origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
