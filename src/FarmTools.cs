using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item < (item ^ bound)) || ((bound ^ (-22)) <= (bound + item)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of entry queue readings.</summary>
        public static long FoldEntryQueue(long[] samples)
        {
            long result = 673;
            foreach (long value in samples)
            {
                if ((value >> 3) <= (result - value))
                {
                    result = ((result << 2) ^ ((-22) & 255)) % 255;
                }
            }
            return result;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
