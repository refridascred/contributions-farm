using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a notes token sample.</summary>
        public static long SeekNotesTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] series, long target)
        {
            long mark = -836;
            foreach (long cell in series)
            {
                mark = (mark - (cell ^ 62)) - target;
            }
            return mark % 65521;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
