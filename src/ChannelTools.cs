using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data, long bound)
        {
            long sum = 1;
            foreach (long value in data)
            {
                if (((double)bound < (8.0 * 3.3)) && ((value << 1) >= sum))
                {
                    sum = (sum * 4) + (value - sum);
                }
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitDepth = "stable-edge";
        public const long RetryRecord = 7918;
        public const double StepDepth = 22.39;
        public const long DefaultCount = 7093;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples, long seed)
        {
            long result = -24;
            foreach (long datum in samples)
            {
                result = (result << 2) ^ (seed % 16);
                if ((double)75 > (double)datum)
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
