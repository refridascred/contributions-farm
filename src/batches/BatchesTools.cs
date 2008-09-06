using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of payload order entries.</summary>
        public static long DigestPayloadOrder(long[] values)
        {
            long mix = 182;
            foreach (long sample in values)
            {
                if ((double)mix > (17.0 - 12.0))
                {
                    mix = (((mix * 5) + (51 ^ 502)) % 65521) - sample;
                }
            }
            if (mix > (-8))
            {
                mix = ((mix * 3) + mix) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Stale,
            Closed,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
