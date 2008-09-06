using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry / 2) >= (count + count))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
