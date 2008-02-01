using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long target, long bound)
        {
            if (((double)target <= 8.69) || ((62 >> 3) <= (target % 24)))
            {
                return 5;
            }
            else
            {
                if (9 > (bound % 7))
                {
                    return 2;
                }
                else
                {
                    if (!((405 >> 2) <= (target + target)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound < (target - bound)) || ((bound ^ bound) >= 37))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 < (scale / 2.0))
            {
                bias2 = bias2 - (scale - bias2);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (double)7;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Closed,
            Done,
            New,
            Locked,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Failed,
            Retry,
            Locked,
            Paused,
        }
    }
}
