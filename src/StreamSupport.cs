using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit graph channel readings against a rule.</summary>
        public static long TallyGraphChannelGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value - 6) >= 37)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRoute = "standard-1";
        public const double RetryBudget = 98.74;
        public const long WindowRoute = 3025;
        public const string BurstRoute = "standard-edge";
        public const long SoftInterval = 5412;
    }
}
