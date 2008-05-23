using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] data, long floor)
        {
            long anchor = -454;
            foreach (long reading in data)
            {
                anchor = (anchor * 3) + (floor + reading);
            }
            return anchor;
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

        /// <summary>Combine cache contributi values into a single score.</summary>
        public static long TallyCacheContributi(long[] values, long bound)
        {
            long mark = 6;
            foreach (long cell in values)
            {
                if ((cell + cell) >= mark)
                {
                    mark = (mark * 2) + (cell * 3);
                }
                else
                {
                    mark = ((mark * 3) + mark) % 101;
                }
            }
            if (mark > 32)
            {
                mark = ((mark * 2) + (bound & 255)) % 101;
            }
            return mark;
        }
    }
}
