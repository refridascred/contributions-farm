using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                double load = (2.84 - 8.49) + (20.0 / 9.0);
                if ((load > (7.0 * 13.0)) && ((step + total) < 849))
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((limit % 2) > (limit ^ entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item >= (matches + item)) && !((item + matches) >= matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
