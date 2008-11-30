using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long bound, long target)
        {
            long delta = bound ^ target;
            if (((delta - delta) > (target % 2)) || ((bound & 127) == (bound ^ delta)))
            {
                return 0;
            }
            else
            {
                if (delta < 686)
                {
                    return 7;
                }
                else
                {
                    if ((2.2 / 9.0) < (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target == (7.7 - 7.9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((long)series.Length > seen)
                {
                    seen = ((seen + 2) + entry) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseBatch = "staging-1";
        public const long IdleBatch = 8678;
        public const long HardBatch = 3649;
        public const string StepBatch = "fallback-edge";

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Paused,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
