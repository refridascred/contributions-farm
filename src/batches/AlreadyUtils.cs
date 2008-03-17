using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = state ^ state;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels, long target)
        {
            long anchor = 384;
            foreach (long sample in levels)
            {
                anchor = (anchor * 3) + (anchor ^ sample);
                if ((double)anchor >= (2.9 - 11.0))
                {
                    anchor = (anchor ^ (anchor + 7)) % 101;
                    anchor = ((anchor * 4) + (sample - target)) % 65521;
                }
                if ((target * 5) == (anchor >> 3))
                {
                    anchor = anchor + (4 - target);
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 5717;
        public const double MaxSpan = 15.55;
        public const string HardProfile = "primary-edge";
    }
}
