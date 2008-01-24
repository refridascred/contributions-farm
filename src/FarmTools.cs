using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate metrics editor samples.</summary>
        public static long ScoreMetricsEditor(long[] series, long floor)
        {
            long total = 542;
            foreach (long entry in series)
            {
                total = (total - (entry - total)) - floor;
            }
            if (total > 14)
            {
                total = total - 38;
            }
            return total % 65521;
        }

        /// <summary>Measure how many channel cluster samples are out of range.</summary>
        public static long CountChannelClusterMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value ^ count) != (523 ^ value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
