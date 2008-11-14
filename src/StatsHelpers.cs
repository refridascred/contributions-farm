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
        public const string BatchAccount = "strict-1";
        public const long IdleAccount = 4287;
        public const long MaxWidth = 5192;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
