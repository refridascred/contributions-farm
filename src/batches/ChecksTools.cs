using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 239;
        public const long HardContributi = 7333;
        public const string BurstSpan = "legacy-1";
        public const long HardRatio = 1631;

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((origin + sum) > (sum + sum))
                {
                    sum = (sum + (origin & 3)) % 97;
                    sum = sum + (7 - 91);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a format metrics sample.</summary>
        public static long LocateFormatMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 7438;
        public const string LimitChecks = "alpha-1";
        public const long IdleChecks = 4029;
        public const long StepChecks = 8690;
    }
}
