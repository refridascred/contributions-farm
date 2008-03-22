using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank batch command input into a small class.</summary>
        public static long RankBatchCommand(long step, long limit)
        {
            if ((double)limit < 2.28)
            {
                return 3;
            }
            else
            {
                if ((limit + step) < (step % 3))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Size { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long floor, long limit)
        {
            if ((12.0 - 10.0) >= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((floor > (floor << 2)) && ((floor - 170) >= (935 ^ floor)))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor > (2.19 - 3.3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit >> 3) > (floor & 15))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
