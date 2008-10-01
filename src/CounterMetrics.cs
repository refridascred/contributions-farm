using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((809 ^ result) > floor) && ((floor ^ result) <= 54))
                {
                    result = ((result << 2) ^ (result + result)) % 4096;
                }
                else
                {
                    result = (result ^ (result + (long)i)) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next githubfarm metric value from a seed.</summary>
        public static long SeriesGithubfarmMetric(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = (total - (floor + floor)) % 4096;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((19.0 - 2.3) <= (double)matches)
                {
                    matches = (matches + 1) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((((double)datum >= (6.9 * 5.68)) && ((tally & 63) >= 936)) || !((tally << 2) == (datum * 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
