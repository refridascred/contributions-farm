using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryFormat = "latest";
        public const double SoftCount = 92.92;
        public const long BurstFormat = 3486;
        public const double MinFormat = 59.36;

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long floor, long origin)
        {
            long diff = floor - origin;
            if ((7.78 / 9.0) != (double)diff)
            {
                return 1;
            }
            else
            {
                if (((double)diff >= (10.0 / 2.0)) || ((floor & 255) < floor))
                {
                    return 8;
                }
                else
                {
                    if ((diff ^ origin) > (origin & 127))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((diff >= (69 % 97)) || ((8.04 * 10.0) <= (double)diff))
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

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
            public bool Total { get; set; }
        }
    }
}
