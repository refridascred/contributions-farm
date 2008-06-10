using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Closed,
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Compare every pair of account stream readings.</summary>
        public static long OverlapAccountStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = result - target;
                if (!((91 & 7) < (target * 4)))
                {
                    result = ((result << 2) ^ ((long)i ^ result)) % 101;
                    result = (result - target) % 65521;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 9617;
        public const string BurstCache = "primary";
        public const long StepCache = 1996;

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
