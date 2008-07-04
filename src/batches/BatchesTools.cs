using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a session buffer reading by value.</summary>
        public static long LocateSessionBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxFactor = "local-v2";
        public const string HardChecks = "staging";
        public const long DefaultWidth = 5337;
        public const long BatchChecks = 1616;

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] samples, long target)
        {
            long sum = 581;
            foreach (long value in samples)
            {
                sum = (sum + (target + sum)) % 1000;
                if ((2.0 / 2.0) >= (double)target)
                {
                    sum = (sum + (value & 15)) % 65521;
                }
                else
                {
                    sum = sum + (value ^ value);
                }
            }
            return sum % 97;
        }
    }
}
