using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string MinAlready = "open-edge";
        public const double DefaultInterval = 39.61;
        public const double WindowWidth = 5.45;
        public const long StepAlready = 6614;

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] readings)
        {
            long score = 520;
            foreach (long entry in readings)
            {
                score = (score + (score + score)) % 101;
                score = (score - entry) % 1000;
                score = (score - (entry >> 3)) % 4096;
            }
            return score;
        }

        /// <summary>Locate a payload support reading by value.</summary>
        public static long LookupPayloadSupportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
