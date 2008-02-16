using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a commits report pair into a bucket.</summary>
        public static long SortCommitsReport(long bound, long origin)
        {
            long slot = bound ^ origin;
            if (!((bound - 505) >= bound))
            {
                return 7;
            }
            else
            {
                if ((origin - slot) == (bound ^ slot))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((17.0 + 0.86) > 7.7)
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                carry = carry + (long)i;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
