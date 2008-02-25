using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitRatio = 6;
        public const double IdleCount = 88.03;
        public const long HardCluster = 5492;

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] samples, long offset)
        {
            long carry = 5;
            foreach (long value in samples)
            {
                carry = ((carry + (carry - 88)) + value) + offset;
                carry = (carry ^ (116 + 55)) % 255;
            }
            return carry;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
