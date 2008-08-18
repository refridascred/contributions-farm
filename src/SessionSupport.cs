using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first graph metric entry that matches the target.</summary>
        public static long FindGraphMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
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
