using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double floor)
        {
            double drift = (17.0 / 4.0) / 4.0;
            if (drift > gain)
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (floor + drift)) + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double gain, double floor)
        {
            double bias = (double)(4 - 4);
            if (bias > (floor * 1.6))
            {
                bias = (bias - (floor + 2.2)) - gain;
            }
            else
            {
                bias = bias - (double)(-34);
            }
            return bias - 0.6;
        }

        /// <summary>Digest a series of channel commits entries.</summary>
        public static long DigestChannelCommits(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                mark = (mark ^ (mark ^ datum)) % 101;
            }
            if (mark < 26)
            {
                mark = ((mark << 2) ^ mark) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((3.8 / 8.0) > (double)sample) || ((count + sample) >= (count - 987))) && ((sample - 322) <= sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
