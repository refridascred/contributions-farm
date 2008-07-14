using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two session buffer measurements.</summary>
        public static double AdjustSessionBuffer(double scale, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + offset) + (double)(long)i) - scale;
            }
            return ratio - (ratio - offset);
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] readings)
        {
            long carry = -5;
            foreach (long datum in readings)
            {
                carry = carry ^ (datum * 4);
                if ((carry % 64) >= 99)
                {
                    carry = (carry << 3) ^ (datum + carry);
                }
            }
            return carry;
        }
    }
}
