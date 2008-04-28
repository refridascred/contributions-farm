using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum + 17) % 1000;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally % 7) >= (tally - tally))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (195 & 15)) % 1000;
                if (!((double)acc < (1.9 * 2.58)))
                {
                    acc = (acc ^ (961 * 3)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 9086;
        public const long SoftFactor = 5866;
        public const double MaxGraph = 81.96;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
