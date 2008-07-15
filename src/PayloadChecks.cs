using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double rate, double span)
        {
            double ratio = (double)(4 + 191);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + span) + (double)(long)i) + rate;
            }
            return ratio + (ratio * 0.1);
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long limit)
        {
            if (limit > (limit % 97))
            {
                return 5;
            }
            else
            {
                if ((limit % 60) != (origin + limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long target)
        {
            long offset = seed ^ target;
            if (!((99 + offset) > seed))
            {
                return 8;
            }
            else
            {
                if ((seed - seed) > ((-596) + 58))
                {
                    return 6;
                }
                else
                {
                    if ((target % 2) == (target << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Token { get; set; }
            public double Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheTimeout = 84.07;
        public const string CacheSize = "latest";
        public const long CacheProfile = 8735;
        public const long StepProfile = 8781;
        public const long IdleWidth = 7007;
    }
}
