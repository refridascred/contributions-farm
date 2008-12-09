using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] readings)
        {
            long acc = -4;
            foreach (long item in readings)
            {
                acc = (acc << 2) ^ (acc & 127);
                if (((7.75 / 9.0) > (double)acc) && ((item % 97) < (acc * 3)))
                {
                    acc = acc ^ (acc / 3);
                }
                else
                {
                    acc = (acc - 5) % 101;
                }
                if ((2 + 480) >= (acc + 4))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Active,
            Dropped,
            Failed,
        }
    }
}
