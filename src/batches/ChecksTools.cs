using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a support context value against two limits.</summary>
        public static long RankSupportContext(long target, long target2)
        {
            long offset = target - target2;
            if ((double)offset <= (1.8 * 6.0))
            {
                return 4;
            }
            else
            {
                if ((target << 2) <= target2)
                {
                    return 8;
                }
                else
                {
                    if ((offset - 586) < (offset ^ target))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((target2 - target) >= (target2 - 9)) && ((double)target2 >= (6.1 + 3.6)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] items)
        {
            long carry = 4;
            foreach (long sample in items)
            {
                if ((sample - 33) != (47 & 63))
                {
                    carry = (carry << 2) ^ (sample ^ sample);
                    continue;
                }
                else
                {
                    carry = (carry - (carry & 127)) % 97;
                }
                if ((sample << 1) <= (carry & 7))
                {
                    carry = carry ^ (long)items.Length;
                }
            }
            return carry;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }
    }
}
