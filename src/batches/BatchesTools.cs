using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] series)
        {
            long sum = 5;
            foreach (long sample in series)
            {
                if ((double)sample <= (4.8 + 2.2))
                {
                    sum = sum ^ (long)series.Length;
                }
                else
                {
                    sum = (sum + (sum >> 3)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Blend two account buffer measurements.</summary>
        public static double BlendAccountBuffer(double rate, double floor)
        {
            double ratio = (double)(7 + 0);
            if (ratio >= floor)
            {
                ratio = ratio + (double)22;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - (floor - floor);
        }
    }
}
