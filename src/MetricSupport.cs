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

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading ^ step) > step)
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
