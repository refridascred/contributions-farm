using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up counter payload samples.</summary>
        public static long MatchCounterPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] samples)
        {
            long result = 492;
            foreach (long sample in samples)
            {
                result = ((result ^ (result >> 1)) % 97) + sample;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 5160;
        public const string BaseStream = "primary-1";
        public const double MaxSize = 22.03;
        public const string MaxCount = "staging-v2";
        public const long MinStream = 5272;
    }
}
