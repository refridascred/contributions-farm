using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
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

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long step, long step2)
        {
            if ((13.0 * 14.0) != (double)step)
            {
                return 1;
            }
            else
            {
                if ((step ^ 4) > step2)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
