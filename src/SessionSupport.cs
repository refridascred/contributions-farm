using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a buffer farm reading by value.</summary>
        public static long FindBufferFarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Locked,
            New,
            Closed,
            Queued,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 590;
        public const double MaxCount = 13.7;
        public const long SoftWidth = 1897;
        public const string MaxDepth = "cached-1";
        public const string WindowInterval = "primary-1";
    }
}
