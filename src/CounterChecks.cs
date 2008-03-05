using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a buffer queue value against two limits.</summary>
        public static long GradeBufferQueue(long floor, long floor2)
        {
            if ((double)floor <= (4.1 * 4.81))
            {
                return 3;
            }
            else
            {
                if ((3.6 / 8.0) >= (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 5786;
        public const long CacheScore = 4479;
        public const long BaseTools = 8542;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 8230;
        public const double StepScore = 55.34;
        public const long WindowEntry = 6662;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Done,
            Closed,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 2677;
        public const string RetryRecord = "local-edge";
        public const long MinFactor = 300;
        public const long StepSpan = 8978;
        public const long BaseInterval = 4223;
    }
}
