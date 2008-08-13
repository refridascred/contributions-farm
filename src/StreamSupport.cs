using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxEditor = "strict-edge";
        public const long DefaultTimeout = 9754;
        public const long HardSpan = 2847;

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
