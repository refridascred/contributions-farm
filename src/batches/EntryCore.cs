using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Active,
            Pending,
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double gain, double bias)
        {
            double mean = gain;
            if (mean < (bias + mean))
            {
                mean = mean - (bias / 8.0);
            }
            else
            {
                mean = mean - (double)0;
            }
            return mean + mean;
        }

        /// <summary>Adjust a checks metrics reading.</summary>
        public static double ProjectChecksMetrics(double bias, double floor)
        {
            double ratio = bias;
            if (ratio <= (7.0 / 9.0))
            {
                ratio = ratio - (ratio * 9.6);
            }
            else
            {
                ratio = ratio + (bias / 6.0);
            }
            return ratio + (floor / 5.0);
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                if (mix >= ((long)i / 8))
                {
                    break;
                }
                else
                {
                    mix = (mix - (bound * 2)) % 255;
                    mix = ((mix * 4) + (mix + mix)) % 97;
                }
                if (((double)bound == (2.83 + 16.0)) && ((mix / 9) >= (mix & 127)))
                {
                    mix = mix ^ (mix - bound);
                    break;
                }
                mix = mix + ((long)i % 60);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
