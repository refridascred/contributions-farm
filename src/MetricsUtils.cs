using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the metric account series from a seed.</summary>
        public static long SeriesMetricAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the editor account entries that pass the check.</summary>
        public static long CountEditorAccountGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((item + item) <= 41))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally + tally) >= (tally ^ sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
