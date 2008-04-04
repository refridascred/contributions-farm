using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Done,
            Pending,
            Synced,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 2601;
        public const string BatchInterval = "cached-1";
        public const long BatchProfile = 4596;
        public const long MaxSize = 7374;
        public const long HardProfile = 901;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + (total & 7)) % 101;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series)
        {
            long mark = -624;
            foreach (long value in series)
            {
                if ((mark & 15) < mark)
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = ((mark << 2) ^ (75 - (-46))) % 1000;
                    mark = mark + (value - mark);
                }
                if (mark <= (mark >> 3))
                {
                    mark = (mark << 3) ^ (value * 5);
                }
            }
            if (mark > 885)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 65521;
            }
            return mark;
        }
    }
}
