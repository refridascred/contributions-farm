using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next cache cluster value from a seed.</summary>
        public static long StepCacheCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Score { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
