using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a stats report pair into a bucket.</summary>
        public static long BucketStatsReport(long target, long seed)
        {
            if (seed <= (seed ^ seed))
            {
                return 0;
            }
            else
            {
                if (!((double)target >= (5.15 / 3.0)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Score { get; set; }
            public double Rank { get; set; }
        }
    }
}
