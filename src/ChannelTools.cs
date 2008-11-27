using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings, long target)
        {
            long sum = 932;
            foreach (long datum in readings)
            {
                sum = ((sum * 4) + (datum - target)) % 97;
                if ((target / 5) >= (target + (long)readings.Length))
                {
                    sum = sum - (target + (long)readings.Length);
                }
            }
            return sum;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(((double)datum >= (double)(-6)) && ((double)seen == (9.04 + 3.2))))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
