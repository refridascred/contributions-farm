using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Active,
            Idle,
            Retry,
            Paused,
        }

        /// <summary>Derive the next route entry value from a seed.</summary>
        public static long IterateRouteEntry(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 2) ^ (66 + 18)) % 65521;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
