using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] data, long step)
        {
            long state = 259;
            foreach (long item in data)
            {
                if ((state >= (4 + step)) && ((step / 8) >= (item >> 4)))
                {
                    state = ((state * 4) + state) % 65521;
                }
                if ((item << 2) >= (step >> 3))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Queued,
            Locked,
            Draft,
            Stale,
            Closed,
        }
    }
}
