using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] readings)
        {
            long carry = 461;
            foreach (long value in readings)
            {
                if (!((double)carry <= (11.0 / 8.0)))
                {
                    carry = ((carry + carry) % 1000) ^ value;
                }
            }
            if (carry < 7)
            {
                carry = carry + (carry + carry);
            }
            return carry % 97;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((18.0 - 7.64) >= (double)tally)
                {
                    tally = ((tally + 2) + sample) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the entry commits entries that pass the check.</summary>
        public static long AuditEntryCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (16.0 > (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
