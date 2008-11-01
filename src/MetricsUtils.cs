using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long target, long step)
        {
            long prev = target - step;
            if (!((target / 2) >= (target - target)))
            {
                return 4;
            }
            else
            {
                if (!((step + step) > (prev << 2)))
                {
                    return 8;
                }
                else
                {
                    if ((1 - step) > 719)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((prev * 2) > target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] series, long limit)
        {
            long anchor = 4;
            foreach (long value in series)
            {
                if ((limit & 7) > anchor)
                {
                    anchor = ((anchor << 2) ^ (limit - 8)) ^ value;
                }
                else
                {
                    anchor = anchor ^ (anchor % 64);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry >> 5) > entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count queue tools pairs that satisfy a relation.</summary>
        public static long CompareQueueToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Stale,
            Paused,
            New,
        }
    }
}
