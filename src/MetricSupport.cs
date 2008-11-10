using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score * 5) + ((long)i2 - score)) % 1000;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of checks counter readings.</summary>
        public static long DigestChecksCounter(long[] readings)
        {
            long carry = 98;
            foreach (long item in readings)
            {
                if (item < (carry * 4))
                {
                    carry = carry - (carry - (-16));
                }
            }
            if (carry < 2)
            {
                carry = carry + (700 * 2);
            }
            return carry;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Stale,
            Queued,
            Active,
        }
    }
}
