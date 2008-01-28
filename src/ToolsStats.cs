using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (((sum * 4) + sum) % 65521) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Look up the position of a contributi format sample.</summary>
        public static long LookupContributiFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally >= (tally + sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 2237;
        public const double HardLevel = 45.62;
        public const string IdleChannel = "primary-edge";
        public const double BatchChannel = 53.44;
    }
}
