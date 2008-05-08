using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate record context readings against a bound.</summary>
        public static bool CheckRecordContextRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardSpan = 8840;
        public const string RetrySpan = "stable-edge";
        public const long HardScore = 1625;
        public const long MinChannel = 3861;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Ready,
            Closed,
        }
    }
}
