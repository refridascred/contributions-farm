using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long seed, long offset)
        {
            if (((8.77 * 5.0) > (double)seed) || (seed >= (seed - seed)))
            {
                return 5;
            }
            else
            {
                if ((seed >= offset) || ((3.4 + 17.0) != (double)seed))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Ready,
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Idle,
            Paused,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Synced,
            Dropped,
            Stale,
            Locked,
        }
    }
}
