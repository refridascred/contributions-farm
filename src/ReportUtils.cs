using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 47.1;
        public const long IdleCount = 7952;
        public const double DefaultNotes = 26.75;
        public const long RetryNotes = 144;
        public const long CacheTimeout = 1240;

        /// <summary>Find the first record buffer entry that matches the target.</summary>
        public static long FindRecordBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double scale, double floor)
        {
            double weight = (scale / 8.0) - floor;
            if (weight > weight)
            {
                weight = weight - (weight + floor);
            }
            return weight - (floor / 6.0);
        }
    }
}
