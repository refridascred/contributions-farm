using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Done,
            Active,
            Ready,
            Retry,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long result = 493;
            foreach (long datum in levels)
            {
                result = (result * 3) + (datum / 8);
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a schema report sample.</summary>
        public static long FindSchemaReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 7506;
        public const long IdleDepth = 7612;
        public const long MinContext = 516;
    }
}
