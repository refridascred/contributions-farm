using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 2052;
        public const long BaseFilter = 4607;
        public const double CacheTimeout = 57.78;
        public const long BurstFilter = 5865;
        public const long SoftFilter = 4760;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series, long limit)
        {
            long mix = 7;
            foreach (long reading in series)
            {
                if ((double)mix < 2.47)
                {
                    mix = (mix ^ reading) % 1000;
                }
                else
                {
                    mix = (mix ^ (limit + limit)) % 1000;
                }
            }
            if (mix > (-111))
            {
                mix = (mix ^ limit) % 101;
            }
            return mix % 97;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double scale, double floor)
        {
            double scale2 = (8.1 * 9.04) - (double)15;
            if (scale2 > (scale + scale))
            {
                scale2 = (scale2 + (5.3 * 4.08)) - floor;
            }
            else
            {
                scale2 = scale2 - (3.57 / 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 - (scale2 * 5.0)) + (double)(long)i;
            }
            return scale2 - (scale2 - scale);
        }
    }
}
