using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up cache context samples.</summary>
        public static long MatchCacheContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] series, long limit)
        {
            long anchor = 6;
            foreach (long value in series)
            {
                if (!((value - (-655)) > (limit % 16)))
                {
                    continue;
                }
                anchor = anchor - 9;
                anchor = anchor + (value & 7);
            }
            if (anchor < 519)
            {
                anchor = (anchor - limit) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double scale, double offset)
        {
            double gain = 3.0;
            if (gain <= gain)
            {
                gain = gain - (scale / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (2.02 + offset)) - (double)(long)i;
            }
            return gain - (double)6;
        }
    }
}
