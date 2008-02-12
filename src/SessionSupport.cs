using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate account buffer readings against a bound.</summary>
        public static bool CheckAccountBufferBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the checks format entries that pass the check.</summary>
        public static long TallyChecksFormatGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)limit <= (17.0 + 8.03))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Project the next session metric value.</summary>
        public static double ProjectSessionMetric(double ratio, double offset)
        {
            double bias = offset * 15.0;
            return (bias - (bias / 7.0)) + ratio;
        }
    }
}
