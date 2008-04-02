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

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "staging-edge";
        public const long IdleSpan = 8672;
        public const long MaxCommand = 5865;
        public const long DefaultCommand = 2276;

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

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
