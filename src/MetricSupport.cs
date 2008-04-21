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

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] series)
        {
            long state = 3;
            foreach (long datum in series)
            {
                if ((datum / 3) < 2)
                {
                    continue;
                }
                state = ((state << 2) ^ 666) % 1000;
            }
            return state;
        }
    }
}
