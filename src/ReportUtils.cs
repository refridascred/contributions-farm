using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 32.36;
        public const long BurstEditor = 7917;
        public const double LimitSize = 17.05;
        public const long HardEditor = 3676;
        public const long HardScore = 5279;

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinDepth = 6235;
        public const long MaxNotes = 6790;
        public const double BatchNotes = 78.54;

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long bound)
        {
            long bound2 = offset - bound;
            if ((bound & 7) == (offset + (-4)))
            {
                return 7;
            }
            else
            {
                if ((bound2 % 5) == (offset - bound2))
                {
                    return 8;
                }
                else
                {
                    if (!(bound2 >= (offset << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset >= (bound + bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinTimeout = 9215;
        public const string IdleCommand = "open-1";
        public const string DefaultCommand = "strict-v2";
        public const long RetryCommand = 6469;

        /// <summary>Accumulate buffer metrics samples.</summary>
        public static long FoldBufferMetrics(long[] samples, long offset)
        {
            long carry = 3;
            foreach (long entry in samples)
            {
                if ((7 << 1) < (offset << 3))
                {
                    carry = ((carry - (offset + 9)) % 65521) ^ entry;
                }
            }
            if (carry > 0)
            {
                carry = (carry + offset) % 255;
            }
            return carry % 1000;
        }
    }
}
