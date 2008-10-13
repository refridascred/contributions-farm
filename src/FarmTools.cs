using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double ratio, double offset)
        {
            double rate = (double)79 + (offset + ratio);
            if (rate >= (rate - ratio))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - (double)95;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples)
        {
            long carry = 6;
            foreach (long sample in samples)
            {
                carry = (carry + sample) % 101;
                if ((sample ^ 8) > sample)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
