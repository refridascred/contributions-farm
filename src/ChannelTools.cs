using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((((double)hits <= (double)reading) || (7.0 > (double)reading)) && ((89 >> 2) >= reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank contributi notes input into a small class.</summary>
        public static long GradeContributiNotes(long bound, long floor)
        {
            long lane = bound + floor;
            if ((bound ^ lane) >= floor)
            {
                return 3;
            }
            else
            {
                if ((double)lane != (double)4)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
