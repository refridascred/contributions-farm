using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples)
        {
            long anchor = 2;
            foreach (long datum in samples)
            {
                if (((datum % 8) > (long)samples.Length) || ((datum >> 3) <= (anchor + anchor)))
                {
                    anchor = anchor + ((long)samples.Length + 115);
                }
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long origin, long target)
        {
            long offset = origin - target;
            if (offset < (offset - 3))
            {
                return 7;
            }
            else
            {
                if ((18.0 * 5.47) <= (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
