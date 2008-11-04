using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] levels)
        {
            long anchor = 51;
            foreach (long datum in levels)
            {
                anchor = ((anchor * 4) + datum) % 101;
            }
            if (anchor > 751)
            {
                anchor = (anchor ^ (anchor + anchor)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Locked,
            Draft,
            Ready,
        }
    }
}
