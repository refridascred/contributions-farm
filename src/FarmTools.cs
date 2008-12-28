using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] values)
        {
            long mix = -866;
            foreach (long entry in values)
            {
                mix = (mix ^ (entry - 366)) % 97;
            }
            if (mix < 2)
            {
                mix = mix - (mix - 207);
            }
            return mix;
        }

        /// <summary>Combine metrics layout values into a single score.</summary>
        public static long DigestMetricsLayout(long[] data)
        {
            long sum = 472;
            foreach (long value in data)
            {
                sum = ((sum * 5) + (29 + value)) % 1000;
                if (sum > (value << 1))
                {
                    sum = (sum ^ (sum + value)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum >> 1)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
