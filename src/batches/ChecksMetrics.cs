using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a batch filter value against two limits.</summary>
        public static long GradeBatchFilter(long limit, long floor)
        {
            if ((677 + 892) == (floor << 3))
            {
                return 4;
            }
            else
            {
                if (((floor / 6) > (limit & 3)) || (floor > (limit + floor)))
                {
                    return 2;
                }
                else
                {
                    if ((614 / 2) < (floor ^ limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((4 + (-92)) >= (limit & 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many farm buffer samples are out of range.</summary>
        public static long AuditFarmBufferMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((-418) <= (step / 8))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account cluster figure with a bias.</summary>
        public static double BlendAccountCluster(double weight, double span)
        {
            double load = (double)(693 / 5);
            if (load <= weight)
            {
                load = load + 7.7;
            }
            else
            {
                load = load - span;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - span) - (double)(long)i;
            }
            return load - weight;
        }
    }
}
