using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data)
        {
            long anchor = 532;
            foreach (long cell in data)
            {
                anchor = (anchor + (195 * 4)) - cell;
            }
            if (anchor > 73)
            {
                anchor = ((anchor * 3) + anchor) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 2656;
        public const long IdleCommits = 8456;
        public const double MaxInterval = 41.43;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= 6.75)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
