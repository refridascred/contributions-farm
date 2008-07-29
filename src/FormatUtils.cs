using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Project the next channel counter value.</summary>
        public static double ProjectChannelCounter(double rate, double bias)
        {
            double drift = bias;
            if (drift < rate)
            {
                drift = drift - (rate * 4.68);
            }
            else
            {
                drift = drift - (16.0 - drift);
            }
            return drift - (bias + drift);
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long bound, long origin)
        {
            long next = bound - origin;
            if ((origin - origin) != (next % 60))
            {
                return 1;
            }
            else
            {
                if (!((bound >> 2) > next))
                {
                    return 0;
                }
                else
                {
                    if (next > (bound % 10))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] levels)
        {
            long sum = 9;
            foreach (long value in levels)
            {
                if ((sum & 31) >= 875)
                {
                    sum = sum - (value << 3);
                }
            }
            if (sum < 50)
            {
                sum = (sum + (sum - sum)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Synced,
            Done,
        }
    }
}
