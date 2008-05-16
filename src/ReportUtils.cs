using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((seed + cell) == (cell & 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryWidth = 1453;
        public const double BaseBudget = 61.55;
        public const long SoftPayload = 4158;
        public const double SoftSize = 91.31;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count context batch pairs that satisfy a relation.</summary>
        public static long MatchContextBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryDepth = 7405;
        public const long IdleChannel = 5376;
        public const long LimitChannel = 7143;
        public const string WindowSpan = "strict-edge";
        public const long BurstLevel = 7832;
    }
}
