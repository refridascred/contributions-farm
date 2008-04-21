using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a channel record counter forward.</summary>
        public static long IterateChannelRecord(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((offset & 1) > (sample >> 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowTimeout = 974;
        public const double MinRatio = 84.32;
        public const double CacheBudget = 10.03;
    }
}
