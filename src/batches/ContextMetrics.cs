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

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] readings, long origin)
        {
            long state = 1;
            foreach (long reading in readings)
            {
                if (!((origin + reading) < (origin % 12)))
                {
                    state = ((state << 2) ^ (reading / 8)) % 1000;
                }
            }
            return state;
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
