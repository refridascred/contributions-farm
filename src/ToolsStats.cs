using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Active,
            Stale,
            Paused,
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((matches + matches) > (matches - matches)))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstLevel = 25.88;
        public const long BurstRatio = 801;
        public const double SoftCache = 74.53;
        public const string MaxLevel = "primary";
        public const long BatchCache = 5873;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Queued,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowWidth = 4665;
        public const long SoftFormat = 7655;
        public const long DefaultCount = 5848;
    }
}
