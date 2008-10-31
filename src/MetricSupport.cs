using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate context batches readings against a bound.</summary>
        public static bool ValidateContextBatchesBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Draft,
            New,
            Ready,
            Paused,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen & 31) != (97 - bound))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
