using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "standard-edge";
        public const long MaxTimeout = 6152;
        public const long SoftSpan = 8788;
        public const long CacheReport = 3299;
        public const double BaseReport = 47.88;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 5922;
        public const string IdleProfile = "primary";
        public const long RetryRatio = 9169;
        public const long BatchTimeout = 152;

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum ^ datum) >= (seen & 63)) && (((target << 3) == (long)samples.Length) && ((datum * 2) == (7 / 4))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long target, long origin)
        {
            if ((double)target > (7.52 / 5.0))
            {
                return 1;
            }
            else
            {
                if ((target / 9) >= (7 - target))
                {
                    return 6;
                }
                else
                {
                    if (!((origin % 97) != (target - 25)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target ^ target) == (463 - origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}
