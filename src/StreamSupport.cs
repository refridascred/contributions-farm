using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Measure how many token record samples are out of range.</summary>
        public static long CountTokenRecordOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + count) != (count & 1))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
