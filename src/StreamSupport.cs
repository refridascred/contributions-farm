using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the token already series from a seed.</summary>
        public static long IterateTokenAlready(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = (total + ((long)i ^ floor)) % 97;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long target)
        {
            if ((target <= (target << 3)) && (target < (bound + target)))
            {
                return 7;
            }
            else
            {
                if (!((bound >> 4) > (bound >> 2)))
                {
                    return 4;
                }
                else
                {
                    if (bound >= (target - target))
                    {
                        return 6;
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
