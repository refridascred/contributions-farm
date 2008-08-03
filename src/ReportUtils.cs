using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many layout route samples are out of range.</summary>
        public static long TallyLayoutRouteHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading + count) >= 8)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a support cluster value against two limits.</summary>
        public static long ClassifySupportCluster(long origin, long offset)
        {
            if (((offset & 63) >= 249) && (offset <= origin))
            {
                return 2;
            }
            else
            {
                if ((offset >> 2) >= offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset << 2) < origin)
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

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                result = result ^ (floor - result);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
