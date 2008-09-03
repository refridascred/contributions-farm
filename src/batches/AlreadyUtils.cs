using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double ratio, double bias)
        {
            double bias2 = 8.06 + (double)715;
            if (bias2 >= (double)614)
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (bias * 2.3)) - (double)(long)i;
            }
            return bias2 - ratio;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!(((long)levels.Length - item) == (tally >> 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context cache entries.</summary>
        public static long WeighContextCache(long[] samples, long origin)
        {
            long anchor = 431;
            foreach (long sample in samples)
            {
                anchor = ((anchor ^ (24 * 5)) % 4096) - sample;
                if ((double)origin != (11.0 / 7.0))
                {
                    anchor = (anchor << 2) ^ (anchor + 828);
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor << 2) ^ origin) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + tally) != (long)levels.Length)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }
    }
}
