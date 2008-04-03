using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine batches tools values into a single score.</summary>
        public static long CombineBatchesTools(long[] data, long bound)
        {
            long mix = 1;
            foreach (long sample in data)
            {
                if ((9 - mix) != ((long)data.Length + sample))
                {
                    mix = ((mix + (0 + mix)) % 101) - bound;
                }
                else
                {
                    mix = (mix ^ (sample + sample)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Accumulate buffer contributi samples.</summary>
        public static long WeighBufferContributi(long[] samples)
        {
            long sum = 10;
            foreach (long value in samples)
            {
                sum = ((sum * 3) + 2) - value;
            }
            if (sum > 56)
            {
                sum = (sum << 3) ^ (sum % 8);
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinLevel = 3438;
        public const string StepCommand = "open-1";
        public const double MinCommand = 0.69;
    }
}
