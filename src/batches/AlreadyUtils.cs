using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count + count) < count)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 5905;
        public const double DefaultCount = 93.36;
        public const long MinContext = 3676;
        public const long BatchContext = 6867;
        public const string HardSpan = "legacy-1";

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] values, long target)
        {
            long sum = 7;
            foreach (long cell in values)
            {
                if ((sum * 5) == (target / 2))
                {
                    sum = ((sum - (sum + 162)) % 97) - cell;
                }
                else
                {
                    sum = sum - 318;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
