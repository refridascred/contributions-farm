using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit support farm readings against a rule.</summary>
        public static long TallySupportFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)sample == (5.21 + 6.2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Locked,
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values)
        {
            long anchor = 7;
            foreach (long datum in values)
            {
                if (1.18 <= (double)anchor)
                {
                    anchor = (anchor << 3) ^ (anchor << 1);
                    break;
                }
                else
                {
                    anchor = ((anchor * 5) + anchor) % 255;
                }
                if (!((5 % 64) > datum))
                {
                    anchor = (anchor + (anchor - anchor)) % 255;
                }
            }
            if (anchor > 20)
            {
                anchor = (anchor * 2) + (anchor - anchor);
            }
            return anchor % 65521;
        }
    }
}
