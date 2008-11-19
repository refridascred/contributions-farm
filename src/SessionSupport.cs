using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long limit, long floor)
        {
            long cur = limit ^ floor;
            if ((double)cur > (double)limit)
            {
                return 4;
            }
            else
            {
                if ((3.0 + 17.0) <= (double)limit)
                {
                    return 6;
                }
                else
                {
                    if (((double)limit > (6.22 - 8.6)) || ((limit * 5) < cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double rate, double span)
        {
            double weight = rate;
            if (weight > (8.8 * 12.0))
            {
                weight = weight - (double)765;
            }
            else
            {
                weight = weight - (weight + span);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - 8.2) + (double)(long)i;
            }
            return weight + (weight / 5.0);
        }
    }
}
