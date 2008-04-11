using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchSpan = "strict";
        public const double BurstCount = 2.72;
        public const long MaxSize = 7859;
        public const long RetryFilter = 8906;
        public const long MaxFilter = 1268;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Locked,
            New,
            Draft,
            Pending,
        }
    }
}
