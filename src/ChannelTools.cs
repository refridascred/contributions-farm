using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + mix) % 255;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 8040;
        public const long RetryMetric = 4347;
        public const long CacheMetric = 7125;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((5.0 - 3.46) >= (double)cell)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
