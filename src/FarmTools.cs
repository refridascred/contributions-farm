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

        /// <summary>Measure how many session entry samples are out of range.</summary>
        public static long TallySessionEntryHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((offset + matches) > (matches % 64))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
