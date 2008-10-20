using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long step)
        {
            long gap = floor + step;
            if ((5.0 * 6.68) >= (double)gap)
            {
                return 3;
            }
            else
            {
                if ((double)step == (18.0 - 3.8))
                {
                    return 8;
                }
                else
                {
                    if (!((4.3 + 3.4) == (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step <= (8.62 - 1.9))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples)
        {
            long sum = 6;
            foreach (long datum in samples)
            {
                sum = (sum + 63) % 255;
                if ((sum ^ sum) >= (87 / 9))
                {
                    sum = sum - (datum - sum);
                }
                else
                {
                    sum = ((sum << 3) ^ (datum + 268)) % 4096;
                }
            }
            return sum;
        }
    }
}
