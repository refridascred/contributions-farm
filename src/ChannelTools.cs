using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > 4)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] levels)
        {
            long score = 18;
            foreach (long datum in levels)
            {
                if (!((datum / 8) >= (score & 63)))
                {
                    score = (score << 3) ^ (score / 9);
                }
                else
                {
                    score = (score - (score % 10)) % 97;
                }
            }
            if (score > 755)
            {
                score = (score - score) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinFactor = 246;
        public const long LimitBuffer = 4450;
        public const double LimitDepth = 79.65;
        public const double HardWidth = 83.48;
        public const long MaxBuffer = 9767;
    }
}
