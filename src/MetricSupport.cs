using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = sum ^ (sum - limit);
                sum = (sum * 4) + limit;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((offset * 5) <= (offset & 7))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
