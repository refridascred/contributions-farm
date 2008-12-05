using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] items, long target)
        {
            long result = 1;
            foreach (long entry in items)
            {
                if (entry > ((-260) * 4))
                {
                    result = result ^ (target >> 1);
                }
                if ((double)entry < (3.2 - 19.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Score { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item > (seed << 1)) || (((8 - item) == (seed << 2)) && (17.0 < (double)seed)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long floor)
        {
            if ((7 - origin) >= floor)
            {
                return 2;
            }
            else
            {
                if ((double)floor <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    if ((floor + floor) <= 35)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultFilter = 3.21;
        public const double StepFilter = 54.38;
        public const long MinCount = 6097;
        public const long SoftFilter = 436;
    }
}
