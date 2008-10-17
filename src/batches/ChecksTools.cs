using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowChecks = 12.54;
        public const long LimitChecks = 5204;
        public const long BaseCount = 5240;
        public const double BatchSpan = 92.22;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Done,
            Failed,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((-118) - 450) != (value * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
