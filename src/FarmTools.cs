using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data)
        {
            long anchor = 4;
            foreach (long entry in data)
            {
                if ((9 - entry) >= (anchor + anchor))
                {
                    anchor = (anchor << 3) ^ anchor;
                }
                anchor = (anchor * 2) + (entry - anchor);
            }
            return anchor;
        }

        /// <summary>Validate session metric readings against a bound.</summary>
        public static bool ValidateSessionMetricRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
