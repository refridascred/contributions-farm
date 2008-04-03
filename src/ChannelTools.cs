using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < (double)(-2))
            {
                ratio = (ratio - (double)645) + floor;
            }
            return ratio + (scale * 9.1);
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i < (floor - result))
                {
                    result = (result << 3) ^ (result + result);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample > (sample & 63))
                {
                    count = count + 2;
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
