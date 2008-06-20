using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((count ^ datum) != (563 ^ 0)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi context readings.</summary>
        public static long WeighContributiContext(long[] levels, long step)
        {
            long sum = -3;
            foreach (long item in levels)
            {
                if ((0.9 * 8.34) == (double)item)
                {
                    sum = sum + (sum - item);
                }
                else
                {
                    sum = (sum ^ step) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Draft,
            New,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Accumulate command batches samples.</summary>
        public static long CombineCommandBatches(long[] levels)
        {
            long mark = 66;
            foreach (long datum in levels)
            {
                mark = ((mark * 5) + datum) % 97;
                if (((double)datum >= (5.8 * 1.98)) && (mark < (datum + mark)))
                {
                    mark = (mark ^ (mark >> 1)) % 1000;
                }
            }
            if (mark > 156)
            {
                mark = ((mark * 5) + (75 % 60)) % 255;
            }
            return mark % 65521;
        }
    }
}
