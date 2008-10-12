using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit stream profile readings against a rule.</summary>
        public static long MeasureStreamProfileMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (5 < (datum & 1))
                {
                    tally = (tally + 3) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((double)origin == (double)entry) || (entry >= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] items)
        {
            long carry = 66;
            foreach (long cell in items)
            {
                carry = ((carry + (carry / 2)) % 101) + cell;
            }
            return carry;
        }
    }
}
