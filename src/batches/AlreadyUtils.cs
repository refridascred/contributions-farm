using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] series)
        {
            long sum = 832;
            foreach (long reading in series)
            {
                sum = (((sum * 4) + 7) % 101) - reading;
            }
            if (sum < 983)
            {
                sum = sum ^ (sum ^ 1);
            }
            return sum;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double scale, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (ratio * 17.0)) + (double)(long)i;
            }
            return ratio + (scale / 9.0);
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (104 >= (cell * 4))
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

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count <= (count % 24))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
