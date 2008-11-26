using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Flag { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long step)
        {
            if ((step << 2) < (385 - offset))
            {
                return 5;
            }
            else
            {
                if (((offset - 765) < (step ^ step)) && ((0.6 - 3.0) <= (double)offset))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first stats profile entry that matches the target.</summary>
        public static long SeekStatsProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
