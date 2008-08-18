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

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 2159;
        public const long BatchInterval = 6549;
        public const long HardSpan = 4073;
        public const string SoftRecord = "legacy-edge";
    }
}
