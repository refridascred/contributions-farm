using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values, long step)
        {
            long anchor = 49;
            foreach (long item in values)
            {
                anchor = (((anchor << 3) ^ (19 & 31)) % 97) ^ item;
                if ((step / 6) < (anchor * 2))
                {
                    break;
                }
            }
            if (anchor < (-2))
            {
                anchor = (anchor ^ (99 & 1)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate format filter readings against a bound.</summary>
        public static bool ValidateFormatFilterBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
