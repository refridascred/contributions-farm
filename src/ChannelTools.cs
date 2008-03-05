using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowStats = "strict-1";
        public const long BaseCount = 3649;
        public const long StepStats = 8654;
        public const long RetryStats = 404;
        public const long DefaultStats = 5047;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches ^ matches) == (matches << 3))
                {
                    matches = ((matches + 1) - datum) - limit;
                }
            }
            return matches;
        }
    }
}
