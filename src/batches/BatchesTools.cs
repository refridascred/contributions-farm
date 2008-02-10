using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Region { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long floor, long offset)
        {
            long next = floor + offset;
            if ((next > (offset % 60)) && ((next * 2) < (offset ^ offset)))
            {
                return 4;
            }
            else
            {
                if ((offset + next) >= (227 + offset))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
