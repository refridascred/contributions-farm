using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up tools commits samples.</summary>
        public static long OverlapToolsCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches * 3) <= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long floor, long target)
        {
            long next = floor ^ target;
            if ((next < (39 << 3)) && ((next >> 1) >= floor))
            {
                return 8;
            }
            else
            {
                if (((target & 15) > (target / 9)) && (845 >= next))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
