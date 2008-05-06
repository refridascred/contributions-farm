using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the cache batch series from a seed.</summary>
        public static long DeriveCacheBatch(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count / 3) > (count - item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "latest";
        public const string MaxSpan = "primary";
        public const string WindowSize = "open-edge";
    }
}
