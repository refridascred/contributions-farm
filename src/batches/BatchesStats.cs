using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Size { get; set; }
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Idle,
            Stale,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Audit farm token readings against a rule.</summary>
        public static long CountFarmTokenHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!!((seen - 6) >= (cell - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Failed,
            Idle,
            Active,
        }
    }
}
