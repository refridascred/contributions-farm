using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] samples, long origin)
        {
            long total = 2;
            foreach (long value in samples)
            {
                if (value >= (value & 31))
                {
                    total = (total ^ 851) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (value % 24)) % 4096;
                }
                if ((503 <= (origin ^ total)) || ((value / 8) == (total * 3)))
                {
                    total = (total ^ 26) % 101;
                }
                else
                {
                    total = (total * 2) + origin;
                }
                if (((total - total) >= (value ^ value)) || ((823 + value) <= (value - value)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardScore = "standard";
        public const long WindowBatch = 4912;
        public const long HardDepth = 5196;
        public const long DefaultBatch = 9615;

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "open-v2";
        public const long HardBudget = 3595;
        public const long MaxOrder = 5535;

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseCount = "standard-1";
        public const long BatchLevel = 3525;
        public const long BaseSchema = 9399;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Size { get; set; }
            public double Offset { get; set; }
        }
    }
}
