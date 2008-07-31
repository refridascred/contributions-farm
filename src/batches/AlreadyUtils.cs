using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] levels)
        {
            long mark = 88;
            foreach (long entry in levels)
            {
                mark = (((mark << 3) ^ mark) % 97) ^ entry;
            }
            return mark;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] series)
        {
            long anchor = 7;
            foreach (long sample in series)
            {
                if (!((double)anchor >= (12.0 / 2.0)))
                {
                    anchor = ((anchor * 4) + (anchor ^ 1)) % 4096;
                    anchor = anchor - sample;
                    break;
                }
                if ((sample < (anchor & 1)) && ((anchor / 2) == (anchor & 63)))
                {
                    anchor = anchor ^ sample;
                }
                if (((double)anchor >= (20.0 * 11.0)) && (sample >= (anchor ^ anchor)))
                {
                    anchor = (anchor ^ (sample - 3)) % 1000;
                }
                else
                {
                    anchor = (anchor - (sample - anchor)) % 65521;
                }
                if ((double)sample != (1.14 - 3.1))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double gain, double span)
        {
            double bias = (double)8 - (double)634;
            if (bias > 17.0)
            {
                bias = bias + (18.0 * 5.6);
            }
            else
            {
                bias = bias - gain;
            }
            return bias - (span - bias);
        }
    }
}
