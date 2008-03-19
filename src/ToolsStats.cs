using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels)
        {
            long acc = 6;
            foreach (long value in levels)
            {
                if (((value + value) < acc) && ((value + 12) >= (acc ^ value)))
                {
                    acc = acc + (value + acc);
                }
                else
                {
                    acc = (acc + (value >> 5)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 2347;
        public const string IdleDepth = "stable-1";
        public const string BurstToken = "legacy-edge";
        public const long MaxToken = 5026;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((190 <= ((long)levels.Length / 4)) || (datum < (datum / 6)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((seed + seed) == (datum + 337)) || ((double)seed > (5.0 * 8.0)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
