using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Done,
            Idle,
            Draft,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double gain = (ratio * 7.4) + ratio;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (double)(long)i) - bias;
            }
            return gain + (gain / 8.0);
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] items, long target)
        {
            long mark = 464;
            foreach (long reading in items)
            {
                if ((reading + 37) <= reading)
                {
                    mark = ((mark * 4) + (57 & 1)) % 101;
                }
                if (9.5 > (double)target)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
