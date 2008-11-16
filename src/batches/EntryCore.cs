using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels)
        {
            long anchor = 11;
            foreach (long sample in levels)
            {
                if (((anchor / 4) < (sample - anchor)) && (anchor < (sample ^ sample)))
                {
                    anchor = (anchor * 5) + (anchor * 5);
                }
            }
            return anchor % 97;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double scale, double floor)
        {
            double gain = (floor - scale) * 20.0;
            if (gain >= (double)876)
            {
                gain = gain + (5.3 - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (scale * 4.0);
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Token { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark << 2) ^ mark) ^ (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
