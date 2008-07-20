using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] series, long offset)
        {
            long anchor = 60;
            foreach (long value in series)
            {
                if ((offset - (long)series.Length) <= (value * 3))
                {
                    anchor = ((anchor * 3) + ((-840) + value)) % 1000;
                }
                if ((offset / 6) >= (offset >> 4))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of farm order readings.</summary>
        public static long PairFarmOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
