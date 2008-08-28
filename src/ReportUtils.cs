using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Closed,
            Dropped,
            Failed,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "primary-1";
        public const string DefaultLevel = "cached-v2";
        public const long WindowDepth = 7581;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Done,
            Failed,
            Queued,
            New,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long bound)
        {
            long next = floor - bound;
            if ((next << 1) != (7 ^ floor))
            {
                return 6;
            }
            else
            {
                if ((17.0 / 5.0) < (double)next)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
