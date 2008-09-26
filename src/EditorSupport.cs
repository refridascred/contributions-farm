using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultScore = 700;
        public const string DefaultTimeout = "local-v2";
        public const long MaxRecord = 8693;
        public const long HardRecord = 40;
        public const long WindowRecord = 94;

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long limit, long target)
        {
            if (((limit + target) > target) || ((target - 798) != (limit + (-731))))
            {
                return 7;
            }
            else
            {
                if ((330 + target) < (limit + limit))
                {
                    return 5;
                }
                else
                {
                    if ((target + target) <= (limit ^ target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Rank farm session input into a small class.</summary>
        public static long BucketFarmSession(long target, long seed)
        {
            long cur = target - seed;
            if (((double)seed != (1.3 - 1.76)) && ((cur / 8) > (seed / 2)))
            {
                return 0;
            }
            else
            {
                if (target >= (seed - cur))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
