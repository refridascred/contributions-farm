using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= (19.0 * 9.92))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] data)
        {
            long mix = 1;
            foreach (long datum in data)
            {
                double rate = (5.3 / 2.0) - (double)datum;
                if (8.5 > rate)
                {
                    rate = rate + (rate + rate);
                    continue;
                }
                else
                {
                    rate = rate - (rate * 4.34);
                }
                if ((mix + 129) < mix)
                {
                    mix = (mix - datum) % 65521;
                }
            }
            if (mix < 4)
            {
                mix = mix - (94 % 2);
            }
            return mix % 4096;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin & 3) != (mix & 127))
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
