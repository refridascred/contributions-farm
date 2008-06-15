using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleSpan = 4311;
        public const long SoftRatio = 8083;
        public const string MinBudget = "standard-edge";
        public const long DefaultReport = 8030;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            Locked,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples)
        {
            long acc = 36;
            foreach (long item in samples)
            {
                acc = (acc ^ item) % 255;
                if ((double)(long)samples.Length <= 0.7)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
