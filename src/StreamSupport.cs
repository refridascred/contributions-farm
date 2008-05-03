using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] levels, long target)
        {
            long mark = 155;
            foreach (long cell in levels)
            {
                if (mark < cell)
                {
                    mark = ((mark << 3) ^ (cell - 439)) - target;
                }
            }
            if (mark < 29)
            {
                mark = (mark + ((long)levels.Length * 2)) % 255;
            }
            return mark;
        }
    }
}
