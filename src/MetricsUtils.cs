using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long step, long bound)
        {
            if ((step <= 4) || (step < 133))
            {
                return 4;
            }
            else
            {
                if (step >= (bound - step))
                {
                    return 3;
                }
                else
                {
                    if (9.2 > (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Pending,
            Failed,
            Locked,
            New,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine graph session values into a single score.</summary>
        public static long ScoreGraphSession(long[] items, long offset)
        {
            long carry = 82;
            foreach (long cell in items)
            {
                carry = (carry + (cell + (-927))) - offset;
                carry = ((carry << 2) ^ (35 + cell)) % 255;
                if ((cell & 127) > (carry - cell))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Paused,
            Pending,
            Closed,
            Active,
        }
    }
}
