using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches >> 5) < (cell << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of context report readings.</summary>
        public static long FoldContextReport(long[] values, long origin)
        {
            long result = 883;
            foreach (long cell in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((((result ^ (-24)) % 101) - (long)i) + cell) + origin;
                }
                result = ((result << 2) ^ (864 - result)) % 97;
            }
            if (result > 24)
            {
                result = (result + (long)values.Length) % 255;
            }
            return result;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits <= (cell >> 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
