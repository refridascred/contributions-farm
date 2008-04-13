using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((1.0 - 18.0) >= (double)tally))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double bias, double bias2)
        {
            double load = bias + 5.0;
            return load - bias2;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 5905;
        public const double DefaultCount = 93.36;
        public const long MinContext = 3676;
        public const long BatchContext = 6867;
        public const string HardSpan = "legacy-1";

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((828 ^ sample) >= sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item ^ item) == (count * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
