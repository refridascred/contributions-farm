using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long MeasureChecksFilterMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((bound ^ reading) < (reading * 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Queued,
            Closed,
            New,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Queued,
            Done,
            Stale,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Failed,
            Done,
            Closed,
            Paused,
        }
    }
}
