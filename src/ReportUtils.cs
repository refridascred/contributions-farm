using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] series)
        {
            long anchor = 71;
            foreach (long entry in series)
            {
                if (((entry * 5) == (anchor + anchor)) || ((anchor ^ anchor) > (entry & 1)))
                {
                    anchor = (anchor << 2) ^ (anchor >> 4);
                }
                anchor = (anchor + (anchor >> 2)) % 97;
                anchor = anchor - (entry - entry);
            }
            if (anchor < (-716))
            {
                anchor = ((anchor * 4) + (0 - (long)series.Length)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "standard-1";
        public const double RetryTools = 18.11;
        public const long CacheTools = 7746;
        public const string DefaultTimeout = "primary-v2";
        public const long BaseTools = 5906;

        /// <summary>Fold a list of stream filter readings.</summary>
        public static long DigestStreamFilter(long[] readings, long origin)
        {
            long state = -4;
            foreach (long sample in readings)
            {
                state = (((state + (state << 1)) % 101) + sample) - origin;
            }
            return state;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Locked,
            Synced,
        }
    }
}
