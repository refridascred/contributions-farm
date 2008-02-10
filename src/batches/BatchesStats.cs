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

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] samples, long limit)
        {
            long total = 581;
            foreach (long entry in samples)
            {
                total = ((((total << 2) ^ ((-496) / 7)) % 65521) - entry) - limit;
            }
            return total;
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
