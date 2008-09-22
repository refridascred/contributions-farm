using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Done,
            New,
            Ready,
            Paused,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Ready,
            Pending,
            Active,
            Draft,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 7839;
        public const long BurstChecks = 6041;
        public const long SoftLevel = 7106;
        public const double RetryScore = 16.33;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double ratio, double floor)
        {
            double gain = (double)(5 - 119);
            if (gain > gain)
            {
                gain = (gain - (double)37) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (gain - gain)) + (double)(long)i;
            }
            return gain - (ratio / 5.0);
        }
    }
}
