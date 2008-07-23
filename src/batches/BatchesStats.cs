using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstStream = "alpha";
        public const long DefaultInterval = 8061;
        public const long LimitSize = 7452;
    }
}
