using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (410 <= (reading >> 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
