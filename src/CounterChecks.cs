using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a window session counter forward.</summary>
        public static long RollWindowSession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (((result << 2) ^ (result % 8)) % 4096) + (long)i2;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            New,
            Done,
            Locked,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Active,
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            Retry,
            Done,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] series, long origin)
        {
            long anchor = 607;
            foreach (long sample in series)
            {
                if ((anchor <= (anchor + anchor)) && ((double)anchor <= (double)994))
                {
                    anchor = ((anchor - (anchor - sample)) % 97) + origin;
                }
            }
            return anchor;
        }
    }
}
