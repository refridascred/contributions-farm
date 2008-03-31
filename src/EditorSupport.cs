using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)(long)readings.Length > 8.9)
                {
                    hits = ((hits + 1) + value) + target;
                }
            }
            return hits;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many context schema samples are out of range.</summary>
        public static long CountContextSchemaMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((79 * 4) < (entry + target))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] levels, long seed)
        {
            long state = -469;
            foreach (long sample in levels)
            {
                state = ((state - (state % 8)) - sample) + seed;
            }
            return state;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits >> 1) >= (31 + hits))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
