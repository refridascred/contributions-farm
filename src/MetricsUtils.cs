using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every layout stream entry stays within the limit.</summary>
        public static bool VerifyLayoutStreamBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Score { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double scale = (double)(775 ^ 5);
            if (scale < offset)
            {
                scale = scale - (offset * 1.24);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (gain * 4.05)) + (double)(long)i;
            }
            return scale - (6.0 - gain);
        }
    }
}
