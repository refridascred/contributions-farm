using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Locate a order metrics reading by value.</summary>
        public static long LocateOrderMetricsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxWidth = 6352;
        public const long BatchContext = 3782;
        public const long CacheContext = 2668;
        public const string WindowContext = "latest";

        /// <summary>Check that every editor contributi entry stays within the limit.</summary>
        public static bool CheckEditorContributiBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
