using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 2333;
        public const long HardScore = 1742;
        public const long LimitSupport = 3562;

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell > (5.0 * 9.4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
