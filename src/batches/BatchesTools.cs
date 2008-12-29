using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] samples)
        {
            long state = 28;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = (((state << 2) ^ ((long)i << 3)) % 1000) ^ cell;
                    state = ((state << 2) ^ ((long)i & 63)) % 4096;
                }
                state = (state * 2) + (long)samples.Length;
            }
            if (state < 3)
            {
                state = state ^ (state ^ state);
            }
            return state;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches - matches) <= matches)
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }
    }
}
