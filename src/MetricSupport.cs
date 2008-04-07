using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark ^ origin) % 97;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches >= (limit - limit)) || ((limit - matches) < (limit + matches)))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Retry,
            Ready,
            Synced,
            Failed,
        }
    }
}
