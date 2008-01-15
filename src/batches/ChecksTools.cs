using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many token support samples are out of range.</summary>
        public static long MeasureTokenSupportHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count << 3) < count)
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count metric batch pairs that satisfy a relation.</summary>
        public static long OverlapMetricBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long sum = 220;
            foreach (long datum in readings)
            {
                if (sum <= ((-583) ^ sum))
                {
                    sum = (sum - (datum + 8)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((32 % 64) >= reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
