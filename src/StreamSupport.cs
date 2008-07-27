using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((96 + datum) > tally)
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleRatio = "cached-edge";
        public const string CacheTimeout = "standard-1";
        public const string MinEditor = "open";
        public const long BatchWidth = 438;
        public const long BurstEditor = 4244;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                total = ((total << 3) ^ step) % 101;
                if ((step >> 3) >= (1 - 515))
                {
                    total = ((total << 2) ^ (total + total)) % 101;
                    total = (total - step) % 1000;
                    break;
                }
                total = (total + (step - step)) % 101;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
