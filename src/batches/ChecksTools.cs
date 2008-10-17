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

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
