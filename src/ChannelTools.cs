using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] values, long target)
        {
            long sum = 73;
            foreach (long sample in values)
            {
                sum = (((sum * 2) + ((long)values.Length + sample)) % 1000) - target;
            }
            return sum;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double rate, double floor)
        {
            double weight = 8.3;
            if (weight > weight)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight - 13.0;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + rate) - (double)(long)i;
            }
            return weight - floor;
        }
    }
}
