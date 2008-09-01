using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long anchor = -25;
            foreach (long value in levels)
            {
                anchor = anchor ^ (anchor - value);
            }
            if (anchor < 42)
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] items, long origin)
        {
            long mix = 19;
            foreach (long sample in items)
            {
                if (((164 ^ mix) >= (54 + (long)items.Length)) && (mix < (sample + mix)))
                {
                    mix = (mix * 5) + (603 & 127);
                }
                if ((origin + mix) <= (mix - 446))
                {
                    mix = ((mix << 3) ^ (mix * 3)) % 255;
                }
            }
            if (mix < 27)
            {
                mix = ((mix << 3) ^ (146 >> 1)) % 101;
            }
            return mix;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double ratio, double span)
        {
            double load = (ratio / 2.0) / 3.0;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + ratio) + (double)(long)i) - span;
            }
            return load + ratio;
        }
    }
}
