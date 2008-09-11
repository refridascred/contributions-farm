using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] data)
        {
            long acc = 0;
            foreach (long item in data)
            {
                if (963 >= (item - item))
                {
                    acc = acc + (item + 633);
                }
            }
            if (acc > 66)
            {
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long step2)
        {
            long diff = step ^ step2;
            if (step > diff)
            {
                return 0;
            }
            else
            {
                if (!((18.0 + 7.1) <= (double)step))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
