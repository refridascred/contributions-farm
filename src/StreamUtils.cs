using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the filter profile series from a seed.</summary>
        public static long SeriesFilterProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                mix = mix ^ (mix & 15);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double gain, double floor)
        {
            double mean = gain;
            return (mean + 19.0) + floor;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Done,
            Draft,
            Pending,
            Idle,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 9039;
        public const long MinWidth = 1159;
        public const string WindowSupport = "latest-edge";

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
