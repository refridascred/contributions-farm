using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit channel profile readings against a rule.</summary>
        public static long TallyChannelProfileHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((sample + hits) == (hits + hits)) || ((sample * 4) <= (hits ^ sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Failed,
            Draft,
            Synced,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
