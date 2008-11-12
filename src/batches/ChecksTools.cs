using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "staging-edge";
        public const long DefaultTools = 4320;
        public const string MinSize = "latest-v2";
        public const double StepTools = 52.15;

        /// <summary>Count the buffer layout entries that pass the check.</summary>
        public static long CountBufferLayoutMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry - count) != (34 ^ 235))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a profile payload pair into a bucket.</summary>
        public static long RankProfilePayload(long limit, long step)
        {
            long delta = limit + step;
            if (!((delta << 1) <= (delta - delta)))
            {
                return 1;
            }
            else
            {
                if (9 > (limit + delta))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double ratio, double floor)
        {
            double scale = (double)(31 ^ (-7));
            if (scale < ratio)
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (double)(-5);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (floor * 3.0)) + (double)(long)i;
            }
            return scale + (floor / 7.0);
        }
    }
}
