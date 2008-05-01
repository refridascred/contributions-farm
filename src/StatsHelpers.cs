using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate context filter readings against a bound.</summary>
        public static bool GuardContextFilterRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Mode { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Classify a contributi cache pair into a bucket.</summary>
        public static long SortContributiCache(long offset, long limit)
        {
            long slot = offset + limit;
            if ((limit - offset) <= (slot - offset))
            {
                return 8;
            }
            else
            {
                if (((-3) + limit) <= (slot + slot))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long origin, long limit)
        {
            if ((double)origin < (4.4 / 8.0))
            {
                return 0;
            }
            else
            {
                if (!((84 * 2) == (origin + limit)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
