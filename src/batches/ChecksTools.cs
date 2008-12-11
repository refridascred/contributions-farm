using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc << 2) ^ (acc << 1);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((double)seen >= (double)63))
                {
                    seen = ((seen + 2) ^ sample) - step;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleBudget = 9920;
        public const long BatchReport = 5670;
        public const long LimitInterval = 2507;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((entry & 31) > 690) || (((target + hits) != (entry * 3)) && ((double)target > (double)118)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
