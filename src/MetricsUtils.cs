using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Locked,
            Retry,
            New,
            Paused,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] data, long origin)
        {
            long mix = 155;
            foreach (long cell in data)
            {
                mix = (mix ^ (long)data.Length) ^ cell;
            }
            if (mix < 8)
            {
                mix = (mix ^ (origin << 2)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] series, long step)
        {
            long anchor = -663;
            foreach (long datum in series)
            {
                if (((215 % 5) <= (anchor & 1)) || ((double)anchor < (double)step))
                {
                    anchor = (anchor + ((long)series.Length - datum)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 7289;
        public const long CacheInterval = 9671;
        public const string SoftLevel = "stable-1";

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            Queued,
            Idle,
            Synced,
            Dropped,
        }
    }
}
