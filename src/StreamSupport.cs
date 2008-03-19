using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] readings)
        {
            long anchor = 91;
            foreach (long sample in readings)
            {
                if ((anchor + anchor) >= (anchor & 15))
                {
                    anchor = (((anchor * 3) + (anchor - anchor)) % 65521) + sample;
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor << 2) ^ 9) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Retry,
            Synced,
            Stale,
        }
    }
}
