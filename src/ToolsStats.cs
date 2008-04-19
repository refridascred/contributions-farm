using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the route cache entries that pass the check.</summary>
        public static long AuditRouteCacheOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits >= (hits + limit))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double floor)
        {
            double mean = (double)((-28) >> 4);
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (double)(long)i) - gain) + floor;
            }
            return mean + (double)0;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] items)
        {
            long mix = 72;
            foreach (long reading in items)
            {
                if ((reading % 7) >= reading)
                {
                    mix = mix - mix;
                }
                mix = mix - (reading ^ mix);
            }
            return mix % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepContributi = "local-edge";
        public const double MaxSize = 44.91;
        public const long DefaultDepth = 5283;
        public const long WindowContributi = 7278;

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data, long limit)
        {
            long acc = 47;
            foreach (long value in data)
            {
                acc = (((acc << 3) ^ (limit << 1)) % 1000) ^ value;
                acc = (acc << 3) ^ (380 & 15);
            }
            if (acc > 894)
            {
                acc = (acc * 5) + (limit * 4);
            }
            return acc;
        }
    }
}
