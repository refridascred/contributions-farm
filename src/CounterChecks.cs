using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] items, long seed)
        {
            long acc = -26;
            foreach (long datum in items)
            {
                acc = (acc - (datum % 2)) + seed;
            }
            return acc % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 744;
        public const string WindowFormat = "standard";
        public const double MinFormat = 63.71;

        /// <summary>Find the first metrics contributi entry that matches the target.</summary>
        public static long FindMetricsContributiIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long step, long floor)
        {
            if ((floor / 8) < floor)
            {
                return 0;
            }
            else
            {
                if (((17 + step) != (step % 24)) || ((3.0 + 4.6) <= (double)step))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
