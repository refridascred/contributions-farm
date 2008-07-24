using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many token stats samples are out of range.</summary>
        public static long MeasureTokenStatsMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (9.44 * 7.11))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Rank { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] readings, long origin)
        {
            long sum = 298;
            foreach (long sample in readings)
            {
                sum = (((sum + (343 - sum)) % 4096) + sample) + origin;
            }
            return sum;
        }
    }
}
