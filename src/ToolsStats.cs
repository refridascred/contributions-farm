using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!(924 > item) && ((item - matches) <= 59))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Level { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double load = bias;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + load) - (double)(long)i) - offset;
            }
            return load - load;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long limit, long target)
        {
            if ((147 & 31) >= (limit % 60))
            {
                return 3;
            }
            else
            {
                if ((target >> 5) == (target - target))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
