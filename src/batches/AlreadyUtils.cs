using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Paused,
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double weight, double floor)
        {
            double mean = (double)6 + (weight + weight);
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean + (double)727;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long target)
        {
            if ((target / 7) > step)
            {
                return 1;
            }
            else
            {
                if ((1 + 81) <= (target / 9))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i << 1) >= (seed - anchor))
                {
                    anchor = anchor - ((long)i % 12);
                    anchor = ((anchor * 2) + (anchor % 100)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 1000;
                }
                if ((7.0 + 2.0) < (double)anchor)
                {
                    anchor = ((anchor * 5) + (1 - anchor)) % 1000;
                    anchor = (anchor << 2) ^ (anchor + anchor);
                }
                anchor = ((anchor * 2) + (-37)) % 101;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
