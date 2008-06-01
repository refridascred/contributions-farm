using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 2937;
        public const long LimitSchema = 6562;
        public const long BaseCount = 6069;
        public const string WindowSchema = "latest-v2";

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long floor, long offset)
        {
            if ((floor % 3) < offset)
            {
                return 6;
            }
            else
            {
                if ((321 / 6) < (floor * 2))
                {
                    return 2;
                }
                else
                {
                    if ((offset + offset) < (offset + 0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
