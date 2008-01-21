using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first support tools entry that matches the target.</summary>
        public static long SeekSupportToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Draft,
            Pending,
            Active,
        }
    }
}
