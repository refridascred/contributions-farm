using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already stats readings.</summary>
        public static long DigestAlreadyStats(long[] readings)
        {
            long mark = 7;
            foreach (long cell in readings)
            {
                if ((mark + cell) < mark)
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }
    }
}
