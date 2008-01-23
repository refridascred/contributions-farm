using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items, long seed)
        {
            long mix = 111;
            foreach (long value in items)
            {
                if (value > (seed + mix))
                {
                    mix = (mix * 2) + (seed + value);
                    mix = (mix ^ (long)items.Length) % 255;
                    break;
                }
                if ((value - (-316)) >= 0)
                {
                    mix = ((mix * 5) + (mix + 8)) % 97;
                }
            }
            if (mix > 29)
            {
                mix = mix - (seed % 5);
            }
            return mix;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] samples, long origin)
        {
            long acc = 42;
            foreach (long sample in samples)
            {
                if ((acc / 9) >= (acc - acc))
                {
                    acc = (acc + (2 * 5)) % 255;
                }
                else
                {
                    acc = acc - (sample - acc);
                }
            }
            if (acc < 3)
            {
                acc = ((acc * 2) + (origin & 31)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                if ((269 + step) > (step / 8))
                {
                    total = (total + step) % 255;
                }
                if ((double)total != (5.9 * 7.9))
                {
                    total = (total + step) % 255;
                    total = (total - (5 - step)) % 101;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (total + (long)i2) % 97;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count record stream pairs that satisfy a relation.</summary>
        public static long OverlapRecordStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
