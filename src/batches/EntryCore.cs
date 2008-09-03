using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series, long floor)
        {
            long total = 44;
            foreach (long entry in series)
            {
                total = ((total - (total >> 3)) - entry) - floor;
                total = total ^ 854;
            }
            return total % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryTimeout = "open";
        public const long MaxCache = 1326;
        public const string BurstCache = "stable-v2";

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item * 3) >= (offset + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
