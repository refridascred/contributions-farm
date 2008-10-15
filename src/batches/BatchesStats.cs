using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long total = 6;
            foreach (long value in items)
            {
                total = (total + value) % 1000;
                if (!((value & 1) > (value + value)))
                {
                    total = (total << 2) ^ (total % 7);
                }
                else
                {
                    total = (total - (total & 7)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] values, long origin)
        {
            long mark = 6;
            foreach (long datum in values)
            {
                if ((datum * 4) != (mark / 5))
                {
                    mark = ((mark << 3) ^ (origin + origin)) % 1000;
                }
            }
            return mark % 4096;
        }
    }
}
