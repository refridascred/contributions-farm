using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate profile entry samples.</summary>
        public static long TallyProfileEntry(long[] values)
        {
            long total = 334;
            foreach (long value in values)
            {
                if (((long)values.Length << 3) < (total + value))
                {
                    total = (total ^ (total ^ 481)) % 255;
                }
                else
                {
                    total = total ^ (total << 2);
                }
            }
            if (total < 146)
            {
                total = ((total * 5) + (total / 4)) % 1000;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleTimeout = "open-1";
        public const long BatchSupport = 7250;
        public const long BaseBudget = 846;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }
    }
}
