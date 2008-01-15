using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public long Region { get; set; }
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

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 <= (15.0 - weight))
            {
                weight2 = weight2 - (weight / 7.0);
            }
            else
            {
                weight2 = weight2 + (weight2 / 5.0);
            }
            return weight2 - (weight2 / 7.0);
        }
    }
}
