using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank layout entry input into a small class.</summary>
        public static long BucketLayoutEntry(long target, long origin)
        {
            long slot = target - origin;
            if (((double)origin >= (0.7 - 15.0)) || ((72 % 97) == (origin + slot)))
            {
                return 8;
            }
            else
            {
                if (!((2.91 / 3.0) > (double)slot))
                {
                    return 7;
                }
                else
                {
                    if ((2.45 + 9.7) > (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
