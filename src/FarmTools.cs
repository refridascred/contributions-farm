using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Active,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (94 >= seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }
    }
}
