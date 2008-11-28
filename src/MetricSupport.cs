using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Done,
            Failed,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
