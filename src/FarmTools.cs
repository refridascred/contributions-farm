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

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
