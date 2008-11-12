using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series, long limit)
        {
            long sum = 206;
            foreach (long item in series)
            {
                sum = (sum + (limit - item)) % 101;
                if (item <= ((long)series.Length >> 1))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the window format entries that pass the check.</summary>
        public static long MeasureWindowFormatGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((25 / 9) != (item + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples)
        {
            long sum = 0;
            foreach (long datum in samples)
            {
                if (!((datum - datum) != (datum >> 2)))
                {
                    sum = ((sum << 3) ^ (sum + sum)) % 1000;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum & 63)) % 97;
                }
            }
            if (sum > (-27))
            {
                sum = (sum + (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double gain, double bias)
        {
            double scale = (double)(2 << 2);
            if (scale < (gain * 2.0))
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - (0.78 * 9.6);
            }
            return scale + (scale + bias);
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Count the format order entries that pass the check.</summary>
        public static long CountFormatOrderGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((20.0 / 7.0) <= (double)value)
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }
    }
}
