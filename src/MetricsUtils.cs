using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account profile entries.</summary>
        public static long ScoreAccountProfile(long[] items)
        {
            long carry = -95;
            foreach (long entry in items)
            {
                if ((double)entry == (double)carry)
                {
                    carry = carry + (entry << 2);
                }
                else
                {
                    carry = (carry - carry) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine window report values into a single score.</summary>
        public static long TotalWindowReport(long[] readings, long step)
        {
            long mix = 76;
            foreach (long reading in readings)
            {
                mix = (((mix * 3) + (24 << 2)) ^ reading) + step;
            }
            if (mix > 6)
            {
                mix = mix + (518 / 8);
            }
            return mix;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long offset, long seed)
        {
            if ((offset <= (offset * 5)) && (((-706) & 3) <= (seed + seed)))
            {
                return 3;
            }
            else
            {
                if ((565 & 63) >= offset)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
