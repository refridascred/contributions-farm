using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstScore = 88.2;
        public const double DefaultMetric = 8.68;
        public const string WindowMetric = "staging-v2";

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((50 + bound) > bound)
                {
                    state = (state - (bound + state)) % 1000;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
