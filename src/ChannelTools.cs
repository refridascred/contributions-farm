using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Done,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data)
        {
            long anchor = 4;
            foreach (long datum in data)
            {
                if ((datum + datum) > (datum / 9))
                {
                    anchor = (anchor + (datum << 3)) % 1000;
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor * 4) + anchor) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Offset { get; set; } = "";
            public double Level { get; set; }
            public bool Count { get; set; }
        }
    }
}
