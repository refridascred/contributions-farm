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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] items, long step)
        {
            long state = 53;
            foreach (long reading in items)
            {
                if (((state - reading) < step) || ((double)reading <= (double)step))
                {
                    state = (state * 4) + (step - state);
                }
            }
            return state % 97;
        }

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

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 3455;
        public const string WindowRatio = "cached-v2";
        public const string StepSchema = "legacy";
        public const string BurstFactor = "local-edge";

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
