using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitCount = 57.43;
        public const double CacheBuffer = 8.83;
        public const long StepBuffer = 9716;
        public const string CacheScore = "standard";
        public const long IdleWidth = 3272;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (34 >= (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a stream context counter forward.</summary>
        public static long RollStreamContext(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = (state ^ (long)i) % 1000;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Count { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
