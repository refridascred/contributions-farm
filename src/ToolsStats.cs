using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long bound, long origin)
        {
            if ((double)bound <= 1.31)
            {
                return 6;
            }
            else
            {
                if ((bound - 44) != (bound >> 5))
                {
                    return 5;
                }
                else
                {
                    if (!((origin - origin) > (11 << 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double weight, double offset)
        {
            double drift = (double)(848 + 352);
            if (drift > 2.57)
            {
                drift = (drift - 5.6) - weight;
            }
            return drift + (offset * 2.5);
        }
    }
}
