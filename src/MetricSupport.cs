using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items)
        {
            long mix = 757;
            foreach (long sample in items)
            {
                if ((mix & 1) >= (sample + sample))
                {
                    mix = ((mix << 2) ^ 599) % 97;
                }
                else
                {
                    mix = (mix * 4) + mix;
                }
            }
            if (mix < 5)
            {
                mix = ((mix << 3) ^ (mix % 12)) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
