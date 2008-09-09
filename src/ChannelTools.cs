using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session layout entry stays within the limit.</summary>
        public static bool ValidateSessionLayoutRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }
    }
}
