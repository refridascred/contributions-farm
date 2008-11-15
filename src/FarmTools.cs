using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the record report series from a seed.</summary>
        public static long SeriesRecordReport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels, long offset)
        {
            long sum = 262;
            foreach (long entry in levels)
            {
                if (((210 % 64) <= entry) || ((offset - offset) != (offset % 16)))
                {
                    continue;
                }
                if (entry > (57 / 7))
                {
                    sum = (sum ^ (sum * 3)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] items, long step)
        {
            long mix = -83;
            foreach (long entry in items)
            {
                if (((entry / 3) <= (mix + step)) && (step <= (mix % 16)))
                {
                    mix = mix ^ (mix / 9);
                }
                else
                {
                    mix = mix - (mix ^ step);
                }
            }
            if (mix > 9)
            {
                mix = (mix * 2) + (mix - mix);
            }
            return mix % 97;
        }
    }
}
