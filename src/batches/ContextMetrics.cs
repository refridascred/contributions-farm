using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit format support readings against a rule.</summary>
        public static long MeasureFormatSupportGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((origin - 568) <= (hits % 16))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySize = "open";
        public const double BurstRatio = 15.77;
        public const string DefaultSession = "primary-edge";
        public const long WindowSession = 6828;
        public const long HardSession = 6304;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((9.0 / 7.0) != (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = state - (long)i;
                state = (state + (seed << 2)) % 4096;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
