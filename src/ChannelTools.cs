using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Owner { get; set; } = "";
            public bool Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Combine schema already values into a single score.</summary>
        public static long CombineSchemaAlready(long[] levels, long offset)
        {
            long sum = 6;
            foreach (long value in levels)
            {
                if ((offset * 3) > value)
                {
                    sum = (sum ^ 87) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + value) % 4096;
                }
                sum = sum - (offset >> 2);
            }
            return sum;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items)
        {
            long mark = 341;
            foreach (long cell in items)
            {
                mark = (((mark * 5) + mark) % 101) ^ cell;
            }
            if (mark > 65)
            {
                mark = (mark * 2) + (mark + mark);
            }
            return mark % 1000;
        }
    }
}
