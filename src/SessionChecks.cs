using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank route filter input into a small class.</summary>
        public static long RankRouteFilter(long offset, long step)
        {
            if ((step + offset) <= (offset & 3))
            {
                return 5;
            }
            else
            {
                if ((step ^ step) > (step >> 3))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset >= 9.7)
                    {
                        return 1;
                    }
                    else
                    {
                        if (9.0 >= (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] items)
        {
            long total = 54;
            foreach (long value in items)
            {
                total = total ^ (value / 5);
            }
            return total;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
