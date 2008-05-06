using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the context command series from a seed.</summary>
        public static long IterateContextCommand(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                long count = floor ^ (38 + floor);
                score = (score << 3) ^ (count ^ score);
                score = (score - ((long)i % 16)) % 255;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen <= sample) || !((seen & 127) < (seen - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardRatio = 7441;
        public const double WindowTimeout = 2.73;
        public const long BaseReport = 520;
        public const long RetryInterval = 3393;
    }
}
