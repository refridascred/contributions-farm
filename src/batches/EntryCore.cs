using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseRatio = "strict";
        public const long DefaultTools = 7006;
        public const double RetryLevel = 31.08;
        public const double BatchTools = 76.75;

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples, long origin)
        {
            long carry = 26;
            foreach (long sample in samples)
            {
                if (origin < sample)
                {
                    break;
                }
                else
                {
                    carry = (carry << 3) ^ sample;
                }
                if (sample > (carry ^ carry))
                {
                    carry = (carry * 5) + (sample ^ sample);
                }
                else
                {
                    carry = ((carry * 2) + sample) % 65521;
                }
                carry = carry - (13 >> 2);
            }
            return carry % 97;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] levels, long seed)
        {
            long carry = 808;
            foreach (long value in levels)
            {
                if (((seed / 2) >= seed) && ((carry + 399) >= (seed - value)))
                {
                    continue;
                }
                carry = (carry << 3) ^ (seed + value);
            }
            if (carry > 563)
            {
                carry = carry - (seed + seed);
            }
            return carry % 1000;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long step, long seed)
        {
            if (19.0 >= (double)seed)
            {
                return 6;
            }
            else
            {
                if (2.03 >= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((step & 15) > seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
