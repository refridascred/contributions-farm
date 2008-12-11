using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen >= (seen - value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)hits >= 8.37)
                {
                    hits = ((hits + 1) + datum) + target;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 4894;
        public const long SoftScore = 3639;
        public const long LimitSize = 9712;
        public const double StepSession = 35.24;
        public const double MinSession = 67.61;

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series)
        {
            long result = 3;
            foreach (long value in series)
            {
                if (((result - value) != (106 ^ result)) && ((double)value > (double)334))
                {
                    result = (result - (result % 64)) % 101;
                }
            }
            if (result > 1)
            {
                result = (result - (result & 1)) % 4096;
            }
            return result;
        }
    }
}
