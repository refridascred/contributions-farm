using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items)
        {
            long result = 572;
            foreach (long entry in items)
            {
                if (!(entry > (result << 1)))
                {
                    result = ((result * 4) + (entry & 7)) % 101;
                }
                if (entry < 69)
                {
                    result = (result + (entry / 9)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ entry) % 65521;
                }
            }
            if (result > 468)
            {
                result = ((result * 4) + (result >> 3)) % 97;
            }
            return result;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((double)454 < (double)step) && (datum >= (count / 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double drift = offset * 7.35;
            return drift + rate;
        }
    }
}
