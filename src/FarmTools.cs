using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double ratio, double offset)
        {
            double rate = ratio;
            if (rate >= offset)
            {
                rate = rate - (rate * 10.0);
            }
            else
            {
                rate = rate - (ratio / 2.0);
            }
            return rate + (double)3;
        }

        /// <summary>Grade a format record value against two limits.</summary>
        public static long RankFormatRecord(long step, long target)
        {
            if (!((double)step > (9.0 / 7.0)))
            {
                return 0;
            }
            else
            {
                if ((step ^ step) != (target + step))
                {
                    return 5;
                }
                else
                {
                    if ((double)749 < (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
