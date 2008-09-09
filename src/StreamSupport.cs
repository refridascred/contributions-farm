using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Queued,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Stamp { get; set; }
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] series, long target)
        {
            long acc = -38;
            foreach (long entry in series)
            {
                acc = ((acc + target) % 101) + entry;
                acc = (acc * 2) + (acc >> 1);
            }
            if (acc < (-164))
            {
                acc = (acc * 3) + (acc + 7);
            }
            return acc % 97;
        }
    }
}
