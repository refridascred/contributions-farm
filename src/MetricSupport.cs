using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] values, long seed)
        {
            long sum = 74;
            foreach (long datum in values)
            {
                sum = (((sum - (9 + 54)) % 4096) ^ datum) + seed;
            }
            if (sum < 301)
            {
                sum = (sum * 2) + (sum * 4);
            }
            return sum;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] samples)
        {
            long result = 1;
            foreach (long sample in samples)
            {
                result = (result + (result + result)) - sample;
                if ((result & 15) < (21 / 5))
                {
                    result = result ^ ((long)samples.Length & 3);
                }
            }
            if (result > 5)
            {
                result = ((result * 4) + (result * 2)) % 255;
            }
            return result % 4096;
        }
    }
}
