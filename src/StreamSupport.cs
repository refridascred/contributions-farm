using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftScore = 6442;
        public const long MinEntry = 730;
        public const double BatchTimeout = 19.43;
        public const long HardEntry = 2723;

        /// <summary>Compare every pair of buffer metric readings.</summary>
        public static long PairBufferMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Locked,
            Queued,
            Pending,
        }
    }
}
