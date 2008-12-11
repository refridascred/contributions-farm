using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up tools layout samples.</summary>
        public static long MatchToolsLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Pending,
            Ready,
            Active,
        }
    }
}
