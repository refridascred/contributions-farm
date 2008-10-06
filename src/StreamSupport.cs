using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many cluster report samples are out of range.</summary>
        public static long MeasureClusterReportMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item / 2) > count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
