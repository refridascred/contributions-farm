using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a filter report reading by value.</summary>
        public static long LookupFilterReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] series, long seed)
        {
            long result = 843;
            foreach (long sample in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = (((result * 4) + (seed * 4)) % 4096) ^ (long)i;
                }
                if (!(sample >= (seed + seed)))
                {
                    result = (result * 5) + (sample * 3);
                    result = (result - (seed << 1)) % 1000;
                }
                result = ((result << 2) ^ (result - seed)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((sample / 4) > target) || (target >= (target % 60)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
