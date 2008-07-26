using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] values)
        {
            long sum = 2;
            foreach (long datum in values)
            {
                sum = ((sum + (sum & 31)) % 4096) ^ datum;
            }
            if (sum < 449)
            {
                sum = (sum + (sum - sum)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Validate batches checks readings against a bound.</summary>
        public static bool VerifyBatchesChecksRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a token order figure with a bias.</summary>
        public static double SmoothTokenOrder(double bias, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (bias + bias)) - (double)(long)i;
            }
            return scale + (7.29 * 8.0);
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
