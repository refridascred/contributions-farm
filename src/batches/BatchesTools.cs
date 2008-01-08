using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Rank layout notes input into a small class.</summary>
        public static long GradeLayoutNotes(long target, long seed)
        {
            if ((3.4 + 5.2) > (double)target)
            {
                return 7;
            }
            else
            {
                if ((8.3 + 3.11) <= (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((seed >> 5) < seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
