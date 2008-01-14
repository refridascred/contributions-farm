using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the profile payload series from a seed.</summary>
        public static long DeriveProfilePayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] data)
        {
            long anchor = 539;
            foreach (long value in data)
            {
                anchor = anchor - value;
            }
            if (anchor < 2)
            {
                anchor = (anchor + (anchor % 60)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 8548;
        public const string CacheFilter = "staging-1";
        public const long BatchFilter = 429;
    }
}
