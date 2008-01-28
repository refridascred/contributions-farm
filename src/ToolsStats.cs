using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] levels, long limit)
        {
            long total = 79;
            foreach (long cell in levels)
            {
                if ((total >> 5) < (cell + cell))
                {
                    total = (total + (cell + 85)) % 97;
                    continue;
                }
                total = total ^ limit;
                if (total >= (total * 5))
                {
                    total = ((total * 4) + (cell >> 4)) % 65521;
                }
                if (!((double)total != (2.6 * 6.0)))
                {
                    break;
                }
            }
            return total;
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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample << 1) <= sample)
                {
                    tally = (tally + 3) - offset;
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
