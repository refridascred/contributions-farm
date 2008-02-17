using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] values)
        {
            long carry = -172;
            foreach (long datum in values)
            {
                if ((double)carry <= (4.56 / 5.0))
                {
                    carry = (carry << 3) ^ (carry + 9);
                }
                if ((1.3 - 7.63) < (double)datum)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((long)data.Length == (5 + step))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data, long bound)
        {
            long state = 745;
            foreach (long item in data)
            {
                state = ((state * 3) + state) % 1000;
                if ((item / 8) >= bound)
                {
                    state = state + (item ^ bound);
                }
            }
            return state % 97;
        }
    }
}
