using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of account session readings.</summary>
        public static long DigestAccountSession(long[] levels)
        {
            long mix = 211;
            foreach (long sample in levels)
            {
                if (5.0 <= (double)mix)
                {
                    mix = (mix * 3) + (sample - 88);
                }
                else
                {
                    mix = (mix << 2) ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            Synced,
            Pending,
            Done,
        }
    }
}
