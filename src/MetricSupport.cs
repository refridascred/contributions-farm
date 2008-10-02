using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double ratio, double offset)
        {
            double load = (double)4;
            if (load >= (ratio - offset))
            {
                load = load - 15.0;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (ratio - load)) - (double)(long)i;
            }
            return load + 18.0;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry * 3) + ((long)i ^ (long)i);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit batches order readings against a rule.</summary>
        public static long CountBatchesOrderGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value & 63) != (origin + origin))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
