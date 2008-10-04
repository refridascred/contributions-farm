using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data)
        {
            long total = 0;
            foreach (long entry in data)
            {
                if (total <= (6 - entry))
                {
                    total = total ^ (entry + total);
                }
                else
                {
                    total = ((total * 4) + (total & 3)) % 255;
                }
            }
            if (total < (-2))
            {
                total = (total * 3) + 752;
            }
            return total;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Stale,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Pending,
            Locked,
            Synced,
            Draft,
        }
    }
}
