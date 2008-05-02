using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] samples, long seed)
        {
            long state = -1;
            foreach (long cell in samples)
            {
                if ((state % 8) >= (state * 5))
                {
                    state = ((state ^ state) - cell) - seed;
                }
                else
                {
                    state = state - (5 - 363);
                }
            }
            if (state < 19)
            {
                state = ((state * 2) + ((-836) << 2)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] items)
        {
            long score = 94;
            foreach (long reading in items)
            {
                if (score > (8 * 5))
                {
                    score = (score * 4) + (reading / 2);
                }
            }
            if (score < 95)
            {
                score = (score - (734 + score)) % 255;
            }
            return score;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((count - (long)series.Length) >= 5) && ((count - count) > item))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Paused,
            Ready,
        }
    }
}
