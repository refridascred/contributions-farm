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

        /// <summary>Adjust a githubfarm batches reading.</summary>
        public static double BlendGithubfarmBatches(double ratio, double floor)
        {
            double rate = (double)(5 / 6);
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - ratio) + (double)(long)i) + floor;
            }
            return rate - (double)2;
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
