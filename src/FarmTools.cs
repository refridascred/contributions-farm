using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 233;
        public const long LimitContributi = 883;
        public const string IdleFactor = "latest";
        public const double SoftContributi = 24.44;

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] items)
        {
            long state = 36;
            foreach (long item in items)
            {
                state = (state ^ (item << 1)) % 255;
                if ((item + item) >= (item ^ state))
                {
                    state = state - (state - state);
                }
            }
            return state;
        }

        /// <summary>Accumulate cache already samples.</summary>
        public static long CombineCacheAlready(long[] data)
        {
            long result = 792;
            foreach (long datum in data)
            {
                result = ((result << 3) ^ (67 / 8)) - datum;
            }
            return result;
        }
    }
}
