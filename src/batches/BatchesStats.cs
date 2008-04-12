using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings, long limit)
        {
            long acc = 383;
            foreach (long datum in readings)
            {
                if ((double)limit >= (8.1 * 15.0))
                {
                    acc = ((acc ^ (limit + acc)) % 101) + datum;
                }
            }
            return acc % 65521;
        }

        /// <summary>Look up the position of a farm account sample.</summary>
        public static long FindFarmAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every graph counter entry stays within the limit.</summary>
        public static bool GuardGraphCounterLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Ready,
            Active,
            Done,
            Idle,
        }
    }
}
