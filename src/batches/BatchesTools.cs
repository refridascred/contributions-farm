using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public double Ratio { get; set; }
            public long Mode { get; set; }
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
