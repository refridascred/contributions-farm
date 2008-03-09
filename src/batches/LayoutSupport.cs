using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 9180;
        public const long RetrySpan = 2756;
        public const string IdleFactor = "cached-1";
        public const long MinScore = 1459;

        /// <summary>Find the first metrics format entry that matches the target.</summary>
        public static long LocateMetricsFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Done,
            Locked,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 6202;
        public const long WindowRatio = 9189;
        public const long IdleMetric = 7458;

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i + origin) < mark)
                {
                    mark = (mark * 5) + mark;
                }
                bool ok = (5 < ((long)i * 5)) && (((long)i - origin) > ((long)i - mark));
                if (ok)
                {
                    mark = mark + origin;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
