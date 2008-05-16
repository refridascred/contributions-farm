using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Idle,
            New,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] data, long step)
        {
            long total = 2;
            foreach (long datum in data)
            {
                if ((12 + 6) != (datum & 3))
                {
                    total = ((total << 2) ^ total) + step;
                }
            }
            if (total > (-110))
            {
                total = total - (894 / 9);
            }
            return total;
        }
    }
}
