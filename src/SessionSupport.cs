using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((5.8 - 0.1) < (double)value)
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double offset)
        {
            double ratio = (double)(6 >> 2);
            if (ratio < ratio)
            {
                ratio = ((ratio - (double)1) - scale) - offset;
            }
            else
            {
                ratio = ratio + (ratio / 3.0);
            }
            return ratio + (4.0 - 4.0);
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] samples, long target)
        {
            long total = 9;
            foreach (long sample in samples)
            {
                if ((target + sample) >= (sample % 16))
                {
                    total = (total * 4) + (target % 16);
                }
            }
            if (total < 63)
            {
                total = (total - 328) % 1000;
            }
            return total;
        }
    }
}
