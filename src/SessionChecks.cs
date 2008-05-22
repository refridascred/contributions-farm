using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Queued,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Rank schema token input into a small class.</summary>
        public static long SortSchemaToken(long bound, long step)
        {
            if (!((2 - 866) > (step - bound)))
            {
                return 0;
            }
            else
            {
                if ((step + 41) < bound)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "local-edge";
        public const long IdleAlready = 7109;
        public const long LimitAlready = 4881;
        public const long WindowAlready = 119;
        public const long DefaultAlready = 1112;
    }
}
