using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepTimeout = 5540;
        public const string BaseRatio = "cached-1";
        public const double HardCluster = 75.32;
        public const double LimitCluster = 91.48;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long result = 786;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result ^ ((long)i / 5)) % 4096;
                }
                result = (result ^ result) % 4096;
                if (((24 * 3) < (sample + 317)) && ((sample % 3) == (origin + 24)))
                {
                    result = result ^ (sample + result);
                }
                if (((58 + sample) < (result - sample)) || ((origin & 7) >= (sample * 2)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally + tally) <= (5 + sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryRatio = 6409;
        public const double HardWidth = 89.6;
        public const string DefaultGithubfarm = "local-edge";
        public const string LimitCount = "legacy-1";
        public const long BatchGithubfarm = 6986;
    }
}
