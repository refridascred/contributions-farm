using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the window token entries that pass the check.</summary>
        public static long MeasureWindowTokenGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((limit + entry) <= (limit / 9))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)4 == (double)count)
                {
                    count = ((count + 3) + sample) - step;
                }
            }
            return count;
        }
    }
}
