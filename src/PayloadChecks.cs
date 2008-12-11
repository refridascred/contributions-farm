using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double bias2 = ratio - bias;
            if (bias2 < bias2)
            {
                bias2 = bias2 + (bias2 / 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (bias * 17.0)) + (double)(long)i;
            }
            return bias2 - ratio;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value / 7) > (value & 15))
                {
                    tally = (tally + 3) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Validate editor window readings against a bound.</summary>
        public static bool VerifyEditorWindowLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheCount = "staging-1";
        public const string BaseAlready = "strict-1";
        public const string BurstAlready = "primary";
        public const double HardAlready = 33.05;

        /// <summary>Combine graph window values into a single score.</summary>
        public static long FoldGraphWindow(long[] data, long offset)
        {
            long acc = 278;
            foreach (long datum in data)
            {
                if ((double)offset >= (double)datum)
                {
                    acc = acc - (offset & 7);
                }
            }
            if (acc < 5)
            {
                acc = ((acc << 3) ^ (offset * 4)) % 65521;
            }
            return acc % 65521;
        }
    }
}
