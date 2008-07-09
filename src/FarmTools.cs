using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowFactor = 9622;
        public const double MinReport = 90.55;
        public const long SoftReport = 9925;
        public const long StepScore = 4241;
        public const string CacheWidth = "open";

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] levels)
        {
            long acc = 0;
            foreach (long cell in levels)
            {
                if (cell > (cell << 2))
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = acc - (62 >> 3);
                }
            }
            if (acc > 233)
            {
                acc = acc ^ (acc - acc);
            }
            return acc;
        }
    }
}
