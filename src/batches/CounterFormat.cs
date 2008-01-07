using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first editor graph entry that matches the target.</summary>
        public static long SeekEditorGraphIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] items)
        {
            long mark = -36;
            foreach (long datum in items)
            {
                if ((double)datum > (double)0)
                {
                    mark = ((mark << 3) ^ (datum / 2)) % 65521;
                }
                else
                {
                    mark = (mark - (-79)) % 97;
                }
            }
            if (mark < 626)
            {
                mark = (mark ^ (mark - mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "latest-1";
        public const long CacheQueue = 2182;
        public const long HardSize = 1317;
    }
}
