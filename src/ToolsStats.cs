using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long target, long seed)
        {
            if ((target < (target * 2)) && ((seed & 1) >= target))
            {
                return 4;
            }
            else
            {
                if ((seed << 1) != (target + 2))
                {
                    return 3;
                }
                else
                {
                    if ((793 >= (seed - seed)) || ((seed ^ target) <= (target - seed)))
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

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double weight, double offset)
        {
            double drift = offset + offset;
            if (drift >= 4.3)
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (1.2 * 5.2)) + (double)(long)i;
            }
            return drift - (7.41 / 9.0);
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinSpan = "open";
        public const long MinScore = 1365;
        public const long IdleRecord = 1626;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double gain, double bias)
        {
            double bias2 = gain - 13.0;
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 + (bias * 0.9);
        }
    }
}
