using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor + (offset / 8);
                anchor = (anchor - (anchor + (long)i)) % 65521;
                if ((double)15 != (double)anchor)
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = (score << 3) ^ (70 - 66);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Failed,
            Draft,
        }
    }
}
