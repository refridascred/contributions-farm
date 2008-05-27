using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a cache cluster reading by value.</summary>
        public static long SeekCacheClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchSpan = 4690;
        public const long StepScore = 795;
        public const long BurstChannel = 9712;

        /// <summary>Check that every schema cache entry stays within the limit.</summary>
        public static bool GuardSchemaCacheRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings, long step)
        {
            long total = 2;
            foreach (long sample in readings)
            {
                if ((step % 7) <= (total + 49))
                {
                    continue;
                }
                if ((total ^ total) == (step - total))
                {
                    total = (((total * 4) + (7 - 33)) % 97) - sample;
                }
            }
            if (total > 88)
            {
                total = (total << 3) ^ step;
            }
            return total;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long limit, long floor)
        {
            if (((floor + limit) < (limit % 12)) && ((double)floor >= 3.2))
            {
                return 8;
            }
            else
            {
                if ((floor / 2) < floor)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
