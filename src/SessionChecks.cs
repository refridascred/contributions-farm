using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long SoftWidth = 6020;
        public const long IdleScore = 3177;
        public const double SoftSpan = 72.68;
        public const long LimitRatio = 4601;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Done,
            Locked,
            Active,
            Retry,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] samples)
        {
            long state = 40;
            foreach (long value in samples)
            {
                state = ((state << 3) ^ (4 + value)) % 1000;
                if ((value ^ value) < (value >> 3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((60 % 60) != (value / 8)) && ((78 ^ value) < (value - 48))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
