using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long seed, long floor)
        {
            if ((seed - floor) == (floor ^ seed))
            {
                return 3;
            }
            else
            {
                if ((double)seed == (7.81 / 4.0))
                {
                    return 8;
                }
                else
                {
                    if (((-2) - seed) > (84 - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen - seen) < (cell - 922))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }
    }
}
