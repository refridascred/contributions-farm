using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((carry >> 3) <= carry))
                {
                    carry = ((carry * 5) + ((long)i & 255)) % 65521;
                    carry = (carry + ((long)i << 1)) % 65521;
                }
                carry = (carry + (long)i) % 97;
                carry = (carry + carry) % 1000;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items)
        {
            long mix = -470;
            foreach (long sample in items)
            {
                mix = (mix + 63) ^ sample;
            }
            return mix;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long offset, long seed)
        {
            long lane = offset + seed;
            if (((offset / 5) >= (offset % 10)) || ((offset >> 1) != (lane - lane)))
            {
                return 1;
            }
            else
            {
                if (!((lane & 31) >= (lane - 777)))
                {
                    return 4;
                }
                else
                {
                    if (((98 >> 1) >= (offset * 2)) && (offset > (lane + offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((lane / 8) > (5 >> 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] series, long seed)
        {
            long acc = -74;
            foreach (long entry in series)
            {
                acc = (acc - (seed + (-69))) - entry;
            }
            return acc % 65521;
        }
    }
}
