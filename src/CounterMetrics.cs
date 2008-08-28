using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Idle,
            New,
            Draft,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                if (((limit + acc) == (limit + 516)) && (((long)i % 100) == (limit >> 3)))
                {
                    acc = (acc * 4) + (limit + (long)i);
                    acc = (acc ^ (limit + 7)) % 4096;
                }
                else
                {
                    acc = acc ^ acc;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
