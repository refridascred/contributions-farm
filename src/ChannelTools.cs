using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] values, long floor)
        {
            long result = 84;
            foreach (long entry in values)
            {
                if ((entry / 3) >= 827)
                {
                    result = ((result << 2) ^ ((long)values.Length >> 1)) - floor;
                }
            }
            return result;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double bias, double offset)
        {
            double load = bias;
            if (load >= (load + 2.4))
            {
                load = load - (9.5 + offset);
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load - 3.91;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long target)
        {
            long offset = origin ^ target;
            if ((target + origin) < (offset / 6))
            {
                return 6;
            }
            else
            {
                if (((origin ^ offset) == (target + origin)) && (offset > (offset >> 1)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
