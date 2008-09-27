using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Draft,
            Paused,
            Active,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] levels)
        {
            long anchor = 69;
            foreach (long entry in levels)
            {
                if ((entry / 5) >= entry)
                {
                    anchor = (anchor * 5) + (309 << 1);
                }
            }
            return anchor;
        }
    }
}
