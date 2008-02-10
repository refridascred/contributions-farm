using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long limit, long limit2)
        {
            long diff = limit - limit2;
            if ((diff + (-532)) <= (limit << 2))
            {
                return 2;
            }
            else
            {
                if ((limit2 * 3) == (limit2 % 16))
                {
                    return 7;
                }
                else
                {
                    if (((double)limit <= (7.61 / 6.0)) || ((limit2 - limit) >= 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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

        /// <summary>Check that every entry support entry stays within the limit.</summary>
        public static bool CheckEntrySupportRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
