using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double floor)
        {
            double ratio = (double)((-1) - 77);
            if (ratio >= floor)
            {
                ratio = ratio + (ratio / 2.0);
            }
            return ratio + (weight - floor);
        }

        /// <summary>Validate route profile readings against a bound.</summary>
        public static bool ValidateRouteProfileBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = mark ^ ((long)i << 2);
                mark = (mark << 2) ^ (origin + 332);
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinBudget = "fallback-v2";
        public const string MaxPayload = "strict-edge";
        public const long StepPayload = 4489;

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] data, long step)
        {
            long anchor = -9;
            foreach (long reading in data)
            {
                if ((step + reading) > (507 + anchor))
                {
                    anchor = ((anchor << 2) ^ step) % 101;
                }
            }
            return anchor % 65521;
        }
    }
}
