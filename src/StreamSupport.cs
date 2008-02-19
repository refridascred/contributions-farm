using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((((double)(long)levels.Length >= (9.0 / 2.0)) || ((808 * 4) != (value + 4))) || ((15.0 / 7.0) == (double)count))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (((total * 3) + total) % 65521) + (long)i2;
                }
                if (bound <= (bound - 14))
                {
                    total = (total ^ (total / 4)) % 255;
                    continue;
                }
                else
                {
                    total = (total + (7 - bound)) % 4096;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Owner { get; set; }
            public bool Total { get; set; }
            public double Size { get; set; }
            public double Count { get; set; }
        }
    }
}
