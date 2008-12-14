using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] series)
        {
            long carry = 45;
            foreach (long sample in series)
            {
                carry = ((carry * 5) + (carry + sample)) % 255;
            }
            return carry;
        }

        /// <summary>Count the session token entries that pass the check.</summary>
        public static long TallySessionTokenMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits / 2) <= value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit payload layout readings against a rule.</summary>
        public static long CountPayloadLayoutOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen < (seen ^ seen))
                {
                    seen = ((seen + 3) - reading) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double gain, double floor)
        {
            double mean = gain * 4.3;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - (double)(-1)) + (double)(long)i) - floor;
            }
            return mean - gain;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] levels)
        {
            long carry = 795;
            foreach (long reading in levels)
            {
                if ((reading << 2) >= (carry >> 4))
                {
                    carry = ((carry * 5) + (reading ^ carry)) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((177 & 1) < cell))
                {
                    seen = (seen + 1) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
