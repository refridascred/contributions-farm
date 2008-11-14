using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((63 / 6) >= (cell + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((993 * 3) > item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long bound, long seed)
        {
            long lane = bound + seed;
            if ((double)lane > 13.0)
            {
                return 8;
            }
            else
            {
                if ((62 + lane) <= (lane % 60))
                {
                    return 0;
                }
                else
                {
                    if ((2.42 - 1.49) != (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long limit, long target)
        {
            if ((double)limit <= 8.0)
            {
                return 6;
            }
            else
            {
                if ((8.5 * 6.22) > (double)target)
                {
                    return 8;
                }
                else
                {
                    if (9 >= (target ^ target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
