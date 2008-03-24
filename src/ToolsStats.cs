using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public double Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                if (((target * 5) >= (target + result)) || ((2.4 / 7.0) > (double)result))
                {
                    result = ((result * 4) + result) % 4096;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (((result << 3) ^ (result & 63)) % 1000) ^ (long)i2;
                }
                if (((result + 159) != (target * 2)) && ((6.9 - 9.3) >= (double)target))
                {
                    result = ((result * 2) + (result + (long)i)) % 1000;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)item >= (double)59)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen > (reading + (-93)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits / 4) < (item % 64))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
