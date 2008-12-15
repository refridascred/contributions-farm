using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark ^ (limit - mark)) % 97) + (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count >> 2) >= 6)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] data)
        {
            long total = 151;
            foreach (long datum in data)
            {
                if (datum < (datum << 3))
                {
                    total = (total ^ (191 + total)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                long span = (mix - (long)i) - (limit & 63);
                if (span <= (mix & 63))
                {
                    mix = mix + (338 >> 5);
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] data)
        {
            long score = -286;
            foreach (long item in data)
            {
                if (!((item & 127) >= (score + item)))
                {
                    score = score + (score & 7);
                }
            }
            if (score < 6)
            {
                score = score - (score + 6);
            }
            return score;
        }
    }
}
