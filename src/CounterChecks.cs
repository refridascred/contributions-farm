using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxWidth = 261;
        public const long IdleDepth = 3441;
        public const long BaseLayout = 3931;

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Active,
            Dropped,
            Closed,
            New,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] series, long target)
        {
            long carry = 92;
            foreach (long reading in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (((carry << 3) ^ reading) % 1000) ^ (long)i;
                }
                if (!((1.0 * 4.0) <= (double)target))
                {
                    carry = carry - target;
                }
                else
                {
                    carry = (carry + reading) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of githubfarm checks readings.</summary>
        public static long FoldGithubfarmChecks(long[] readings)
        {
            long anchor = 6;
            foreach (long item in readings)
            {
                anchor = ((anchor << 3) ^ 31) + item;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 889;
        public const double BurstTools = 94.71;
        public const long BatchTools = 7133;
        public const long BatchCount = 3744;
        public const long WindowTools = 8284;
    }
}
