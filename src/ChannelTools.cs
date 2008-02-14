using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((983 - bound) < (878 << 1)) && (sample > (477 >> 5)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "standard-1";
        public const long SoftFactor = 5639;
        public const long MaxSize = 8945;
        public const long IdleSize = 2876;
        public const double WindowLayout = 1.16;
    }
}
