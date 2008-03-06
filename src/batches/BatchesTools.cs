using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)floor < (4.8 - 12.0))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Derive the next profile editor value from a seed.</summary>
        public static long DeriveProfileEditor(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                if ((2.9 - 4.8) != (double)anchor)
                {
                    anchor = (anchor ^ (359 + anchor)) % 97;
                }
                anchor = (anchor + (985 - (long)i)) % 97;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
