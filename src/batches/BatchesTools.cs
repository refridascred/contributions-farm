using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] items)
        {
            long score = 853;
            foreach (long value in items)
            {
                if ((score >> 2) != (value - score))
                {
                    score = score ^ (score / 5);
                }
                if (127 <= (score + value))
                {
                    score = ((score << 3) ^ (1 + value)) % 4096;
                }
            }
            if (score > 892)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Validate metrics session readings against a bound.</summary>
        public static bool ValidateMetricsSessionBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 7289;
        public const long BatchSchema = 4531;
        public const double IdleDepth = 31.12;
    }
}
