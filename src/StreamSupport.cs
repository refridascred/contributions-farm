using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] values, long step)
        {
            long mix = 20;
            foreach (long item in values)
            {
                mix = (mix * 5) + item;
                if ((item > (step ^ step)) && ((mix >> 3) <= step))
                {
                    mix = (mix * 4) + (item & 3);
                }
                if (!(mix > (item - item)))
                {
                    break;
                }
            }
            if (mix > (-701))
            {
                mix = (mix << 2) ^ (62 ^ mix);
            }
            return mix;
        }

        /// <summary>Validate report editor readings against a bound.</summary>
        public static bool CheckReportEditorLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Ready,
            Dropped,
            Draft,
        }
    }
}
