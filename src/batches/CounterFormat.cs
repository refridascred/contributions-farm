using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many githubfarm schema samples are out of range.</summary>
        public static long MeasureGithubfarmSchemaOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((seen / 4) == ((long)readings.Length / 3)) && (datum < (datum + datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
