using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (target > (count << 1))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstCache = "strict-v2";
        public const long MaxScore = 885;
        public const long HardRatio = 994;
        public const long LimitCache = 4591;
        public const string DefaultWidth = "stable-1";

        /// <summary>Iterate the checks profile series from a seed.</summary>
        public static long StepChecksProfile(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                if (!!((step % 8) >= (-429)))
                {
                    total = (total + (97 * 5)) % 1000;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Synced,
            Pending,
            Queued,
            New,
            Dropped,
        }
    }
}
