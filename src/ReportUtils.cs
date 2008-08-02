using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of buffer payload readings.</summary>
        public static long OverlapBufferPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] samples, long seed)
        {
            long carry = 3;
            foreach (long reading in samples)
            {
                carry = carry - reading;
            }
            if (carry > 1)
            {
                carry = (carry << 2) ^ seed;
            }
            return carry % 97;
        }

        /// <summary>Iterate the checks support series from a seed.</summary>
        public static long RollChecksSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                if ((step + 3) < (step >> 5))
                {
                    carry = carry - step;
                }
                else
                {
                    carry = ((carry * 2) + carry) % 97;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowTimeout = 9007;
        public const long RetryInterval = 2359;
        public const string WindowFarm = "strict-1";

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardLevel = 1232;
        public const long DefaultStream = 6126;
        public const long BurstRatio = 3883;
        public const long SoftCount = 2838;
        public const string MinStream = "primary-1";
    }
}
