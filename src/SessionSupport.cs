using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftCount = 6723;
        public const string MinContext = "staging-edge";
        public const long StepContext = 4046;
        public const double SoftInterval = 40.29;
        public const long DefaultRatio = 9532;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine tools buffer values into a single score.</summary>
        public static long FoldToolsBuffer(long[] readings)
        {
            long total = 2;
            foreach (long value in readings)
            {
                total = (total ^ (98 + value)) % 4096;
                if (total >= (value * 5))
                {
                    total = (total - (long)readings.Length) % 4096;
                }
            }
            if (total > (-6))
            {
                total = (total << 3) ^ (total + 8);
            }
            return total;
        }
    }
}
