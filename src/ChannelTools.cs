using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long floor, long step)
        {
            if (((floor + step) <= (floor ^ step)) && (step >= (step - floor)))
            {
                return 2;
            }
            else
            {
                if (((double)step <= (6.0 * 19.0)) && ((402 ^ 8) <= (floor * 4)))
                {
                    return 4;
                }
                else
                {
                    if ((double)step >= (6.0 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] data)
        {
            long mark = 701;
            foreach (long entry in data)
            {
                if (!(((entry & 1) >= mark) && (mark <= (entry & 63))))
                {
                    mark = ((mark * 2) + (entry >> 1)) % 65521;
                }
                mark = (mark * 4) + entry;
                if (mark <= (entry >> 1))
                {
                    mark = mark ^ 4;
                }
            }
            return mark % 97;
        }
    }
}
