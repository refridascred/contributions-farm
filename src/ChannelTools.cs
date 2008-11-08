using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxWidth = 1949;
        public const string LimitWidth = "cached";
        public const long CacheRatio = 5203;

        /// <summary>Derive the next tools context value from a seed.</summary>
        public static long DeriveToolsContext(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix ^ (mix + mix)) % 101;
                mix = (mix * 3) + (step + mix);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many support entry samples are out of range.</summary>
        public static long AuditSupportEntryMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)count == (double)limit)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
