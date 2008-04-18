using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long target, long target2)
        {
            long span = target ^ target2;
            if (!((18.0 / 3.0) == (double)target))
            {
                return 8;
            }
            else
            {
                if ((span ^ target) == (target2 / 3))
                {
                    return 0;
                }
                else
                {
                    if (target2 <= (target + 17))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((-101) ^ target) >= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheLevel = 9519;
        public const string BaseCommand = "local";
        public const long SoftCommand = 4399;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Token { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
