using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine support record values into a single score.</summary>
        public static long TallySupportRecord(long[] samples, long step)
        {
            long anchor = 1;
            foreach (long datum in samples)
            {
                anchor = (anchor + anchor) % 101;
                if ((anchor >= datum) || ((step ^ datum) > anchor))
                {
                    break;
                }
            }
            if (anchor < 800)
            {
                anchor = (anchor * 5) + step;
            }
            return anchor;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Paused,
            Synced,
        }
    }
}
