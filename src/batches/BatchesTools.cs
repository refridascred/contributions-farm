using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen + 0) <= item) || (((origin + item) == (983 & 1)) && ((double)seen >= (1.09 + 7.7))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a cluster order counter forward.</summary>
        public static long IterateClusterOrder(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark * 5) + limit;
                if (!(((38 << 1) == (mark - (long)i)) && ((mark & 127) < ((-248) ^ limit))))
                {
                    mark = (mark * 5) + (mark % 60);
                    mark = mark ^ 79;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
