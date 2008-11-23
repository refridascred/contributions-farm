using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long floor, long origin)
        {
            long offset = floor + origin;
            if (((double)offset < 7.99) || ((floor - 69) == (floor + offset)))
            {
                return 2;
            }
            else
            {
                if (offset <= origin)
                {
                    return 6;
                }
                else
                {
                    if (offset < (origin % 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
