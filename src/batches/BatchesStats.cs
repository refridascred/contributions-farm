using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Draft,
            New,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Ready,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long target, long step)
        {
            if (!((target % 16) >= (step * 4)))
            {
                return 7;
            }
            else
            {
                if (target > (step >> 2))
                {
                    return 1;
                }
                else
                {
                    if ((step >> 4) < (target / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((1.5 + 9.0) >= (double)target) || (target <= (9 + step)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitSpan = 74.99;
        public const long WindowReport = 2949;
        public const long MinLevel = 8703;
        public const double CacheReport = 59.62;
    }
}
