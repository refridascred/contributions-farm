using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] values, long limit)
        {
            long score = 7;
            foreach (long reading in values)
            {
                if ((limit ^ 35) <= (reading + reading))
                {
                    score = ((score << 3) ^ (-7)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepInterval = 49.51;
        public const string BurstAlready = "standard-1";
        public const long CacheAlready = 5282;
        public const long StepRatio = 1600;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = result + 9;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
