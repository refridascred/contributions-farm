using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long floor, long step)
        {
            if ((3.8 >= (double)floor) && ((floor - floor) < step))
            {
                return 7;
            }
            else
            {
                if ((6.0 - 7.01) >= (double)step)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine editor format values into a single score.</summary>
        public static long DigestEditorFormat(long[] items)
        {
            long mark = 0;
            foreach (long entry in items)
            {
                mark = (mark << 2) ^ (6 - 94);
                if (!((entry % 64) <= (entry * 4)))
                {
                    mark = (mark << 3) ^ (entry + mark);
                }
            }
            if (mark < 339)
            {
                mark = ((mark << 3) ^ (mark * 5)) % 4096;
            }
            return mark;
        }
    }
}
