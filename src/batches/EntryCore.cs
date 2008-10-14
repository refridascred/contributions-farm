using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit profile stream readings against a rule.</summary>
        public static long MeasureProfileStreamMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value - tally) >= (tally + floor))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] values)
        {
            long anchor = 0;
            foreach (long datum in values)
            {
                anchor = ((anchor * 4) + anchor) ^ datum;
            }
            return anchor;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long state = 351;
            foreach (long value in samples)
            {
                state = ((state + (8 ^ state)) % 1000) ^ value;
            }
            return state % 4096;
        }
    }
}
