using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            New,
            Pending,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of context farm entries.</summary>
        public static long ScoreContextFarm(long[] values, long limit)
        {
            long anchor = -926;
            foreach (long cell in values)
            {
                anchor = ((anchor << 3) ^ (cell ^ limit)) % 65521;
            }
            if (anchor < 94)
            {
                anchor = ((anchor << 3) ^ anchor) % 255;
            }
            return anchor;
        }
    }
}
