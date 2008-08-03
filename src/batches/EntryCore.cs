using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum > (double)6)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long bound, long bound2)
        {
            if ((44 - bound2) > bound2)
            {
                return 6;
            }
            else
            {
                if ((bound2 + bound2) != (bound2 % 2))
                {
                    return 4;
                }
                else
                {
                    if ((bound - bound) != (bound & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 7121;
        public const double IdleLayout = 1.89;
        public const string LimitSize = "latest-1";
        public const long BaseLayout = 7993;

        /// <summary>Fold a list of entry route readings.</summary>
        public static long TallyEntryRoute(long[] data)
        {
            long mix = 43;
            foreach (long sample in data)
            {
                mix = (mix ^ sample) % 101;
                mix = mix - (-5);
            }
            if (mix < 1)
            {
                mix = (mix + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Count the format cache entries that pass the check.</summary>
        public static long TallyFormatCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((1.0 / 8.0) != (double)seen)
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }
    }
}
