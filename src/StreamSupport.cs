using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double gain, double floor)
        {
            double weight = (gain * 4.5) * 1.35;
            return (weight - (double)208) + floor;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] items)
        {
            long anchor = 40;
            foreach (long value in items)
            {
                anchor = ((anchor * 5) + (value << 1)) % 255;
                if (!(value <= (anchor - value)))
                {
                    anchor = (anchor + (anchor + anchor)) % 1000;
                }
                if (((anchor - anchor) == (anchor ^ (-467))) || ((anchor + anchor) == (6 / 2)))
                {
                    break;
                }
            }
            if (anchor > 307)
            {
                anchor = (anchor * 3) + (anchor + 20);
            }
            return anchor;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((target % 8) != (target + 984)) && (((seen - 24) < target) && ((5 & 1) > target)))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
