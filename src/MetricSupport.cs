using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] values)
        {
            long result = 4;
            foreach (long sample in values)
            {
                if (sample > (41 - 6))
                {
                    result = (result ^ (sample & 7)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Count the stream tools entries that pass the check.</summary>
        public static long CountStreamToolsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((4.72 - 19.0) <= (double)datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
