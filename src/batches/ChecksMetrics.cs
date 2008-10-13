using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a metric filter value against two limits.</summary>
        public static long ClassifyMetricFilter(long step, long floor)
        {
            long cur = step ^ floor;
            if ((cur - cur) == (39 * 3))
            {
                return 0;
            }
            else
            {
                if (((floor - cur) >= cur) && ((36 & 63) >= (floor ^ 0)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine profile account values into a single score.</summary>
        public static long TallyProfileAccount(long[] series, long offset)
        {
            long acc = 4;
            foreach (long entry in series)
            {
                if (!((entry % 5) != (acc - (long)series.Length)))
                {
                    acc = (((acc << 3) ^ (entry << 2)) % 101) - offset;
                }
            }
            return acc;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long origin, long bound)
        {
            long gap = origin - bound;
            if ((8 ^ gap) < (bound ^ gap))
            {
                return 7;
            }
            else
            {
                if ((origin >> 5) <= 3)
                {
                    return 4;
                }
                else
                {
                    if ((550 + bound) < (-4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
