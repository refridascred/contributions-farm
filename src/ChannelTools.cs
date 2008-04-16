using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] values, long target)
        {
            long anchor = 89;
            foreach (long value in values)
            {
                anchor = anchor - (value << 3);
                if (anchor <= (value * 4))
                {
                    anchor = (anchor << 3) ^ (anchor + anchor);
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor < (-371))
            {
                anchor = (anchor ^ target) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowSize = 4806;
        public const long HardSize = 2422;
        public const long BurstSpan = 4799;
        public const string HardStream = "fallback-edge";
    }
}
