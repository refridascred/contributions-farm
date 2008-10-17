using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseSpan = 270;
        public const long BaseCommand = 9956;
        public const long IdleBudget = 9424;
        public const double StepInterval = 84.17;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 75.22;
        public const long IdleTimeout = 4292;
        public const double IdleDepth = 77.47;

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
