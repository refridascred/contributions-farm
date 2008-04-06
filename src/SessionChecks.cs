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

        /// <summary>Combine schema layout values into a single score.</summary>
        public static long TotalSchemaLayout(long[] readings)
        {
            long state = 536;
            foreach (long value in readings)
            {
                if ((double)state < (double)value)
                {
                    state = (state + (value << 3)) % 65521;
                }
            }
            if (state < 9)
            {
                state = state - (state * 3);
            }
            return state;
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
