using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Closed,
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitBudget = 9991;
        public const long BaseRatio = 3180;
        public const long SoftInterval = 2940;
        public const long BaseSize = 1325;

        /// <summary>Measure how many token order samples are out of range.</summary>
        public static long CountTokenOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((7.0 - 9.1) != (double)hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((8 / 3) == (item / 9))
                {
                    hits = (hits + 2) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a contributi metrics value against two limits.</summary>
        public static long BucketContributiMetrics(long step, long step2)
        {
            if ((3.13 * 6.0) == (double)step)
            {
                return 3;
            }
            else
            {
                if ((59 * 5) >= (step ^ step2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
