using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally < (tally + reading)) && ((reading * 3) > reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the layout profile series from a seed.</summary>
        public static long SeriesLayoutProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry ^ (carry - floor)) % 101;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
