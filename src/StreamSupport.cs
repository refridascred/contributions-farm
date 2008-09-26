using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Active,
            Failed,
            Idle,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] values, long seed)
        {
            long mark = 489;
            foreach (long item in values)
            {
                if ((5 + item) >= (mark + item))
                {
                    mark = (mark << 2) ^ (seed + mark);
                }
            }
            if (mark < 2)
            {
                mark = ((mark * 5) + (86 - mark)) % 97;
            }
            return mark;
        }
    }
}
