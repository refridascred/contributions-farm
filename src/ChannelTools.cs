using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine route commits values into a single score.</summary>
        public static long ScoreRouteCommits(long[] data)
        {
            long sum = 159;
            foreach (long entry in data)
            {
                sum = ((sum << 2) ^ 6) % 4096;
                if (((double)33 == (double)sum) && ((double)entry >= (3.15 - 9.8)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }
    }
}
