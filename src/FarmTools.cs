using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
