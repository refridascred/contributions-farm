using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] data)
        {
            long total = 125;
            foreach (long entry in data)
            {
                total = total ^ (total - entry);
                if ((double)total != (14.0 * 4.1))
                {
                    break;
                }
            }
            if (total < (-599))
            {
                total = (total + (total + total)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long target, long target2)
        {
            if ((target2 * 4) > (target2 & 255))
            {
                return 8;
            }
            else
            {
                if ((double)target <= (5.0 / 4.0))
                {
                    return 3;
                }
                else
                {
                    if (target <= (target2 + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((target + 0) < target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
