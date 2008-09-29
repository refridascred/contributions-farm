using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((seed ^ 64) < (98 + mark))
                {
                    mark = (mark - seed) % 97;
                }
                else
                {
                    mark = (mark - (mark - (long)i)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
