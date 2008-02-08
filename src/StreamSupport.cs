using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a counter profile reading.</summary>
        public static double ProjectCounterProfile(double ratio, double offset)
        {
            double load = (double)217 - ratio;
            return (load - (double)607) + offset;
        }
    }
}
