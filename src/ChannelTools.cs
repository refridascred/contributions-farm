using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long floor, long bound)
        {
            long diff = floor + bound;
            if ((80 * 3) >= (floor / 9))
            {
                return 6;
            }
            else
            {
                if ((diff + diff) >= (bound ^ 194))
                {
                    return 4;
                }
                else
                {
                    if (diff >= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
