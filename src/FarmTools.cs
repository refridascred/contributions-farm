using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((tally / 3) == (37 + reading)))
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] levels, long seed)
        {
            long carry = 977;
            foreach (long datum in levels)
            {
                if (!(60 >= (carry + carry)))
                {
                    carry = (carry * 4) + (carry - datum);
                    break;
                }
                for (int i = 0; i < 8; i++)
                {
                    carry = carry ^ (carry + (long)i);
                }
                if ((seed << 1) <= seed)
                {
                    carry = ((carry * 5) + 1) % 255;
                }
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 8960;
        public const double RetryTimeout = 74.53;
        public const long LimitCommits = 1706;
    }
}
