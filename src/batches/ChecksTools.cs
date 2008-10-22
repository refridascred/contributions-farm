using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long seed, long offset)
        {
            if ((7 >> 2) == (offset >> 5))
            {
                return 3;
            }
            else
            {
                if (((offset + offset) >= (42 % 7)) && ((offset >> 2) > seed))
                {
                    return 4;
                }
                else
                {
                    if ((9.4 / 6.0) < (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit batch report readings against a rule.</summary>
        public static long CountBatchReportMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((double)sample != (7.0 * 1.4)) && ((double)count > (7.9 - 1.3)))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item + item) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
