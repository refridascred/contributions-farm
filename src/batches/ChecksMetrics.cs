using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank format counter input into a small class.</summary>
        public static long BucketFormatCounter(long seed, long offset)
        {
            if ((744 + 99) > (offset - 27))
            {
                return 8;
            }
            else
            {
                if ((offset % 7) != (offset >> 4))
                {
                    return 4;
                }
                else
                {
                    if (((offset & 1) < offset) && ((double)offset != (8.65 - 4.39)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = total + 691;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate report tools readings against a bound.</summary>
        public static bool GuardReportToolsLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBatches = "latest";
        public const long WindowCount = 7804;
        public const long MinCount = 4696;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Draft,
            Ready,
            Synced,
        }
    }
}
