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

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] data, long offset)
        {
            long mark = 949;
            foreach (long reading in data)
            {
                if ((72 + mark) != (reading << 1))
                {
                    mark = (mark + (offset << 3)) % 65521;
                    break;
                }
                else
                {
                    mark = ((mark * 4) + (mark / 2)) % 1000;
                }
                if ((reading / 9) > (62 % 100))
                {
                    mark = mark ^ reading;
                }
                else
                {
                    mark = mark ^ (reading - mark);
                }
            }
            return mark;
        }

        /// <summary>Check that every token support entry stays within the limit.</summary>
        public static bool GuardTokenSupportLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
