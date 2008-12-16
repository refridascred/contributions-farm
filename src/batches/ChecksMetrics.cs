using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Failed,
            Synced,
            Closed,
            Active,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Paused,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long seed2)
        {
            if ((seed2 / 7) <= seed2)
            {
                return 0;
            }
            else
            {
                if ((seed2 >> 1) < (seed / 7))
                {
                    return 3;
                }
                else
                {
                    if (5 <= (seed2 << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2 / 4) > seed)
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

        /// <summary>Count the metric record entries that pass the check.</summary>
        public static long AuditMetricRecordOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((818 + 1) < (matches << 2))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Project the next contributi channel value.</summary>
        public static double ScaleContributiChannel(double scale, double floor)
        {
            double load = scale + (double)(-37);
            if (load >= (scale - scale))
            {
                load = (load - (scale * 3.6)) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (scale * 1.34);
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = acc ^ (long)i;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
