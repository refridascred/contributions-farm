using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long offset, long limit)
        {
            if ((offset % 10) <= offset)
            {
                return 7;
            }
            else
            {
                if (((limit << 3) == (limit + limit)) && ((offset ^ limit) != (offset * 3)))
                {
                    return 1;
                }
                else
                {
                    if ((5.5 * 5.8) > (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate stream contributi samples.</summary>
        public static long WeighStreamContributi(long[] items)
        {
            long sum = 151;
            foreach (long item in items)
            {
                if (!((double)item > 3.98))
                {
                    sum = (sum ^ item) % 101;
                }
            }
            return sum;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
