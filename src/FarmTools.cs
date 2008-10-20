using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstQueue = 48.86;
        public const long MaxLevel = 7758;
        public const string SoftQueue = "latest-edge";
        public const long SoftBudget = 3649;

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
