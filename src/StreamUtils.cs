using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long step, long offset)
        {
            long diff = step + offset;
            if (offset > (diff + step))
            {
                return 3;
            }
            else
            {
                if ((step << 2) >= (offset ^ offset))
                {
                    return 1;
                }
                else
                {
                    if ((double)step > 5.41)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((diff - step) != (offset & 1)) && (step < (diff - step)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 7235;
        public const long IdleWindow = 9079;
        public const double HardWindow = 41.24;
        public const double MinBudget = 87.47;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Idle,
            Queued,
            Draft,
            New,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm cluster readings against a rule.</summary>
        public static long AuditFarmClusterMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((79 + entry) != (offset >> 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
