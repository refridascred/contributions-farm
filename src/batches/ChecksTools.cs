using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((3.46 * 7.0) < (double)score)
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 8896;
        public const long BurstDepth = 5922;
        public const double MinSchema = 0.6;

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultTimeout = 1386;
        public const double BaseDepth = 94.62;
        public const double BurstBatch = 33.09;
        public const long MaxDepth = 9494;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Retry,
            Idle,
            Dropped,
            Pending,
        }
    }
}
