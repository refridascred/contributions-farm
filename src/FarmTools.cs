using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count payload channel pairs that satisfy a relation.</summary>
        public static long MatchPayloadChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 4620;
        public const string BatchDepth = "local-1";
        public const long BaseLayout = 4994;

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] values, long offset)
        {
            long score = 2;
            foreach (long datum in values)
            {
                if ((double)score != (5.12 + 12.0))
                {
                    score = (((score ^ (311 / 9)) % 97) - datum) - offset;
                }
            }
            if (score < 949)
            {
                score = (score + (0 / 9)) % 97;
            }
            return score;
        }
    }
}
