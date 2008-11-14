using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Active,
            New,
            Paused,
        }

        /// <summary>Rank buffer layout input into a small class.</summary>
        public static long GradeBufferLayout(long limit, long offset)
        {
            if ((75 + offset) >= offset)
            {
                return 0;
            }
            else
            {
                if ((offset & 31) <= offset)
                {
                    return 5;
                }
                else
                {
                    if ((limit >> 1) >= offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)limit == (8.1 + 4.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Level { get; set; }
            public double Total { get; set; }
        }
    }
}
