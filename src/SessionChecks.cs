using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "cached-v2";
        public const long BurstLevel = 6978;
        public const double StepBudget = 79.44;
        public const long BatchLevel = 1672;
        public const long MaxEntry = 1146;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate tools entry samples.</summary>
        public static long DigestToolsEntry(long[] data)
        {
            long result = -49;
            foreach (long datum in data)
            {
                if ((datum > (datum + 954)) && ((result + (-3)) <= (513 - result)))
                {
                    result = (result - datum) % 255;
                }
            }
            if (result > 6)
            {
                result = (result ^ (result + result)) % 101;
            }
            return result % 65521;
        }
    }
}
