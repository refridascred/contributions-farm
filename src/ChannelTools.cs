using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                if (((-3) / 2) != ((long)i ^ mark))
                {
                    mark = (mark ^ (long)i) % 255;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Draft,
            Active,
            Failed,
        }
    }
}
