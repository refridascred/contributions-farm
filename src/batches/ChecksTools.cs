using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftRatio = 9.59;
        public const long HardLayout = 6078;
        public const long WindowLayout = 4374;
        public const string HardScore = "alpha";

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Failed,
            New,
            Active,
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Limit { get; set; }
            public double Count { get; set; }
            public long Score { get; set; }
        }
    }
}
