using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Synced,
            Locked,
            Done,
        }
    }
}
