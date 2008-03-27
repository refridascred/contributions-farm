using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the editor support entries that pass the check.</summary>
        public static long TallyEditorSupportOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((target + cell) > target)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long step, long bound)
        {
            if (bound < (bound & 127))
            {
                return 5;
            }
            else
            {
                if ((double)step <= (7.8 / 4.0))
                {
                    return 6;
                }
                else
                {
                    if ((8.5 * 7.93) <= (2.58 + 0.3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] samples, long seed)
        {
            long carry = 63;
            foreach (long entry in samples)
            {
                if ((carry ^ 8) != ((long)samples.Length - entry))
                {
                    carry = (carry ^ (entry ^ entry)) % 101;
                }
                else
                {
                    carry = carry + (carry % 12);
                }
                if (((seed >> 2) > (seed - seed)) || ((seed & 31) == (seed % 7)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] data)
        {
            long mark = 65;
            foreach (long value in data)
            {
                mark = mark + (5 - mark);
                if ((double)value >= (16.0 + 6.9))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
