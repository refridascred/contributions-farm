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

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((entry % 2) > (count % 12)))
                {
                    count = count + 2;
                }
            }
            return count;
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
