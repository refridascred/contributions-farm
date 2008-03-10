using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate window batches readings against a bound.</summary>
        public static bool CheckWindowBatchesRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] levels)
        {
            long state = 79;
            foreach (long entry in levels)
            {
                if ((double)entry > (2.0 * 5.0))
                {
                    state = ((state * 3) + (entry - (long)levels.Length)) % 97;
                }
            }
            if (state > 49)
            {
                state = ((state << 3) ^ (state % 97)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Validate stream context readings against a bound.</summary>
        public static bool ValidateStreamContextBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((hits ^ hits) == (value - hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up window schema samples.</summary>
        public static long CompareWindowSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
