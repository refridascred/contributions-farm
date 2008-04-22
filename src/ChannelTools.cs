using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the already context entries that pass the check.</summary>
        public static long TallyAlreadyContextMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches < (long)data.Length)
                {
                    matches = ((matches + 1) + reading) - limit;
                }
            }
            return matches;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowWidth = 7746;
        public const double MaxInterval = 22.61;
        public const long MaxSpan = 9628;
        public const string LimitScore = "latest-edge";
        public const long MaxCount = 8236;
    }
}
