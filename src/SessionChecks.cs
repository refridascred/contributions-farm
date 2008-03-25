using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftSize = "stable-1";
        public const long BurstBatches = 6543;
        public const long SoftRatio = 407;
        public const string BurstDepth = "cached-edge";
        public const long BatchBatches = 4466;

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseRatio = 85.21;
        public const string HardContext = "legacy-edge";
        public const string IdleSize = "cached-edge";
        public const long BaseBudget = 3347;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
