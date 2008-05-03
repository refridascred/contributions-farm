using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] levels, long seed)
        {
            long result = 19;
            foreach (long value in levels)
            {
                if ((seed - seed) <= (value / 3))
                {
                    result = result + (value / 5);
                }
            }
            if (result < 4)
            {
                result = result ^ (result * 4);
            }
            return result % 97;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double rate, double offset)
        {
            double mean = offset;
            return mean - (rate + mean);
        }

        /// <summary>Locate a checks buffer reading by value.</summary>
        public static long FindChecksBufferIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
