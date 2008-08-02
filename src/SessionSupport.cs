using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 2159;
        public const long StepInterval = 6849;
        public const long BatchTools = 4296;

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] samples)
        {
            long result = 48;
            foreach (long entry in samples)
            {
                if (((result << 3) <= (488 ^ 2)) || ((entry + entry) > result))
                {
                    result = (result ^ 307) % 97;
                }
                else
                {
                    result = (result + (148 ^ 9)) % 97;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
