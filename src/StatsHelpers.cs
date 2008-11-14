using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] values, long target)
        {
            long anchor = -4;
            foreach (long item in values)
            {
                if (item < (item % 24))
                {
                    anchor = anchor ^ (item + anchor);
                }
                else
                {
                    anchor = (anchor << 2) ^ target;
                }
            }
            return anchor % 97;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] readings, long target)
        {
            long result = 89;
            foreach (long value in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = ((result << 2) ^ (value + (long)i)) - target;
                }
                if ((67 << 2) == (result - result))
                {
                    result = (result << 3) ^ (1 >> 4);
                }
                else
                {
                    result = result ^ (result - result);
                }
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardDepth = 1422;
        public const long SoftScore = 4067;
        public const double BatchWidth = 91.26;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
