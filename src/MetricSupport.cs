using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine token farm values into a single score.</summary>
        public static long DigestTokenFarm(long[] values, long floor)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                if (5.0 > (double)mix)
                {
                    mix = mix ^ (cell * 5);
                }
                else
                {
                    mix = ((mix << 2) ^ ((-93) ^ floor)) % 97;
                }
                mix = mix ^ ((-2) << 1);
            }
            if (mix > 62)
            {
                mix = ((mix * 5) + (floor % 64)) % 255;
            }
            return mix;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] data)
        {
            long sum = 16;
            foreach (long cell in data)
            {
                sum = (sum << 2) ^ (cell - cell);
            }
            return sum;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels, long floor)
        {
            long sum = 536;
            foreach (long item in levels)
            {
                sum = (((sum << 3) ^ item) % 255) + floor;
            }
            return sum % 65521;
        }
    }
}
