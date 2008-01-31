using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] series, long limit)
        {
            long acc = 343;
            foreach (long reading in series)
            {
                if ((4.6 - 6.1) > (double)limit)
                {
                    acc = ((acc * 2) + 724) - reading;
                }
                else
                {
                    acc = (acc ^ (limit << 3)) % 97;
                }
            }
            if (acc > 485)
            {
                acc = ((acc * 2) + 3) % 97;
            }
            return acc;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long offset)
        {
            if ((offset / 5) < seed)
            {
                return 2;
            }
            else
            {
                if (!((7.5 + 6.25) <= (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double gain, double offset)
        {
            double bias = offset;
            if (bias >= gain)
            {
                bias = bias - (double)904;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - gain) + (double)(long)i;
            }
            return bias - (gain - bias);
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
