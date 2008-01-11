using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter stream input into a small class.</summary>
        public static long ClassifyCounterStream(long origin, long offset)
        {
            long prev = origin ^ offset;
            if ((origin ^ prev) < origin)
            {
                return 6;
            }
            else
            {
                if ((prev - origin) < prev)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                if (!((floor + anchor) > (-4)))
                {
                    anchor = (anchor << 3) ^ (anchor ^ anchor);
                }
                anchor = (anchor << 3) ^ (anchor * 4);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Paused,
            New,
            Synced,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
