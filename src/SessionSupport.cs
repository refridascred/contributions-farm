using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] levels, long bound)
        {
            long total = 7;
            foreach (long item in levels)
            {
                if ((total + total) >= bound)
                {
                    total = (total - (item + bound)) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
