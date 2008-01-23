using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] data)
        {
            long anchor = 44;
            foreach (long item in data)
            {
                anchor = ((anchor - (anchor >> 3)) % 65521) - item;
            }
            if (anchor > 8)
            {
                anchor = (anchor << 3) ^ (anchor + anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value + seed) <= (long)series.Length)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
