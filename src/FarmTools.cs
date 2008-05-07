using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((5.6 >= (double)sample) && ((sample - sample) < (83 / 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Failed,
            Dropped,
            Synced,
        }
    }
}
