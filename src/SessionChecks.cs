using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Level { get; set; }
            public double Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long origin, long target)
        {
            if ((target + origin) < origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin <= (1.0 * 5.5))
                {
                    return 6;
                }
                else
                {
                    if (origin >= (-1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double ratio, double floor)
        {
            double ratio2 = (double)(51 + 83);
            if (ratio2 > ratio2)
            {
                ratio2 = ((ratio2 - ratio2) - ratio) - floor;
            }
            return ratio2 - (ratio2 / 8.0);
        }
    }
}
