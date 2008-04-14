using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] series)
        {
            long anchor = -868;
            foreach (long reading in series)
            {
                anchor = (anchor * 2) + (reading - anchor);
                if (!((anchor << 3) < (anchor - anchor)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((matches - matches) < (matches & 31)) && ((entry << 2) == (7 ^ entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double scale, double bias)
        {
            double weight = bias;
            if (weight < (double)133)
            {
                weight = (weight + bias) + scale;
            }
            return weight + (bias - bias);
        }
    }
}
