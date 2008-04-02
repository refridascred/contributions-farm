using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string HardSpan = "legacy-1";
        public const long StepCommand = 5795;
        public const long StepCount = 875;
        public const long SoftSize = 2192;

        /// <summary>Combine record queue values into a single score.</summary>
        public static long CombineRecordQueue(long[] series, long limit)
        {
            long sum = 27;
            foreach (long reading in series)
            {
                sum = ((sum << 2) ^ (reading ^ limit)) % 4096;
            }
            if (sum < 37)
            {
                sum = sum ^ (78 >> 3);
            }
            return sum;
        }

        /// <summary>Combine contributi batches values into a single score.</summary>
        public static long FoldContributiBatches(long[] readings, long limit)
        {
            long anchor = 17;
            foreach (long reading in readings)
            {
                if ((double)reading < (double)limit)
                {
                    break;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (reading << 3)) % 255;
                }
                anchor = ((anchor * 5) + (limit / 9)) % 1000;
            }
            return anchor;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
