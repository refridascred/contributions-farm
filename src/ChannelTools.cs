using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxSpan = 689;
        public const long RetryReport = 8658;
        public const double MinReport = 96.12;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((889 >= (seen + seen)) || ((14.0 + 2.45) < (double)item)))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
