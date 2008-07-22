using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double bias, double floor)
        {
            double weight = bias * 11.0;
            if (weight < (weight * 3.0))
            {
                weight = (weight - bias) - floor;
            }
            else
            {
                weight = weight + bias;
            }
            return weight - 9.0;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "cached-1";
        public const string LimitSize = "open";
        public const long DefaultTimeout = 2796;
        public const long DefaultAlready = 1155;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
