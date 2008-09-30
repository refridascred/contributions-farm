using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] data, long origin)
        {
            long anchor = 421;
            foreach (long reading in data)
            {
                if ((reading / 2) == ((long)data.Length & 255))
                {
                    anchor = (anchor - (anchor - reading)) - origin;
                }
                else
                {
                    anchor = (anchor ^ (anchor << 2)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Failed,
            Dropped,
            Done,
            Retry,
        }
    }
}
