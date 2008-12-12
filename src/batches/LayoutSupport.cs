using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double rate, double offset)
        {
            double rate2 = offset * 7.0;
            for (int i = 0; i < 3; i++)
            {
                rate2 = ((rate2 + offset) - (double)(long)i) + rate;
            }
            return rate2 + offset;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Done,
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Grade a counter metrics value against two limits.</summary>
        public static long ClassifyCounterMetrics(long offset, long offset2)
        {
            long lane = offset + offset2;
            if ((lane / 5) <= (offset2 % 60))
            {
                return 4;
            }
            else
            {
                if ((3.2 / 9.0) > 10.0)
                {
                    return 7;
                }
                else
                {
                    if ((offset * 4) != (lane >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double gain, double span)
        {
            double drift = span;
            if (drift <= (double)46)
            {
                drift = (drift - (1.33 - span)) - gain;
            }
            return drift - drift;
        }
    }
}
