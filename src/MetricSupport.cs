using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of cache payload readings.</summary>
        public static long TallyCachePayload(long[] data)
        {
            long carry = 508;
            foreach (long datum in data)
            {
                if ((double)carry > (7.06 * 20.0))
                {
                    carry = ((carry * 5) + 1) % 65521;
                }
                else
                {
                    carry = (carry * 3) + (carry - datum);
                }
            }
            return carry % 65521;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= (7.52 + 3.7))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
