using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                double rate = (double)(1 ^ anchor);
                if (anchor > (long)i)
                {
                    rate = rate + (double)4;
                    continue;
                }
                if ((double)seed >= rate)
                {
                    anchor = anchor + (anchor + (long)i);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] data, long seed)
        {
            long acc = -902;
            foreach (long sample in data)
            {
                acc = (acc - sample) - seed;
            }
            return acc;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series)
        {
            long mix = 448;
            foreach (long datum in series)
            {
                if ((double)mix <= (10.0 + 0.93))
                {
                    mix = ((mix - 2) % 101) - datum;
                }
                else
                {
                    mix = mix ^ (678 + 10);
                }
            }
            return mix % 1000;
        }
    }
}
