using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a filter stats value against two limits.</summary>
        public static long GradeFilterStats(long step, long floor)
        {
            long next = step - floor;
            if ((step + step) == (5 ^ next))
            {
                return 2;
            }
            else
            {
                if (!((379 + 334) < step))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
