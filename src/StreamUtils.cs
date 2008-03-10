using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit report graph readings against a rule.</summary>
        public static long TallyReportGraphMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((3.0 + 7.78) != (double)reading)
                {
                    seen = (seen + 2) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
