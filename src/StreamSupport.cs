using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a checks metric reading by value.</summary>
        public static long LocateChecksMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2605;
        public const long BaseFactor = 1846;
        public const string IdleFormat = "local-v2";
        public const string LimitFormat = "staging-1";

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                double gain = (double)carry - (double)floor;
                if (gain > 14.0)
                {
                    carry = carry + ((long)i + 35);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
