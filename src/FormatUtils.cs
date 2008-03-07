using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long target, long bound)
        {
            if (bound > target)
            {
                return 2;
            }
            else
            {
                if (449 >= target)
                {
                    return 3;
                }
                else
                {
                    if ((7.0 * 2.11) == (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((201 % 2) >= target)
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

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum == (8.0 + 6.24))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Locked,
            Active,
            Pending,
            Done,
            Stale,
        }

        /// <summary>Scale a payload support figure with a bias.</summary>
        public static double AdjustPayloadSupport(double weight, double bias)
        {
            double weight2 = 3.94;
            if (weight2 >= (weight2 / 9.0))
            {
                weight2 = (weight2 + (double)5) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + bias) - (double)(long)i;
            }
            return weight2 - (weight2 - 13.0);
        }
    }
}
