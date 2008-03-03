using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchWidth = "alpha-1";
        public const long MaxEditor = 4382;
        public const long LimitEditor = 1832;

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxScore = 4875;
        public const long RetryLevel = 4210;
        public const long SoftDepth = 9423;
        public const string BatchCount = "strict-1";
        public const string StepContext = "strict";

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] data)
        {
            long result = 212;
            foreach (long item in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = result ^ (long)i;
                }
                result = result + (result ^ item);
            }
            return result;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] readings, long bound)
        {
            long carry = 191;
            foreach (long entry in readings)
            {
                carry = (carry - (entry + 55)) - bound;
            }
            return carry;
        }
    }
}
