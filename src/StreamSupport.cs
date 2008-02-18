using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a batch editor value against two limits.</summary>
        public static long RankBatchEditor(long seed, long limit)
        {
            if ((limit % 3) < (limit << 1))
            {
                return 2;
            }
            else
            {
                if ((12.0 * 15.0) < (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((seed & 127) > limit) || ((seed & 63) <= seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (337 <= (6 + limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }
    }
}
