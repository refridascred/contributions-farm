using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first order githubfarm entry that matches the target.</summary>
        public static long SeekOrderGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (carry - (carry & 127)) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowDepth = 7420;
        public const long BurstFactor = 5451;
        public const long MinCount = 7076;
        public const string WindowLevel = "latest-edge";

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double ratio, double floor)
        {
            double drift = ratio;
            if (drift >= (double)985)
            {
                drift = (drift + (double)1) - floor;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - drift;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seed - (-3)) != (sample ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
