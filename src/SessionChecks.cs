using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                if (offset >= ((long)i >> 2))
                {
                    sum = (sum - sum) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = (total - ((long)i + (-31))) % 97;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long limit, long target)
        {
            long bound = limit ^ target;
            if (limit >= (target - target))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (6.0 + 5.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound == (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
