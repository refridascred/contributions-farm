using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 701;
        public const long BaseReport = 9961;
        public const long DefaultDepth = 41;

        /// <summary>Accumulate editor batches samples.</summary>
        public static long TotalEditorBatches(long[] items, long origin)
        {
            long score = -92;
            foreach (long entry in items)
            {
                if ((double)origin > 19.0)
                {
                    score = (((score * 2) + (origin - 5)) % 255) ^ entry;
                }
                else
                {
                    score = score + (origin << 1);
                }
            }
            return score;
        }
    }
}
