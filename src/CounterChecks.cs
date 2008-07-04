using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftSpan = 9431;
        public const long HardRatio = 4430;
        public const string HardChannel = "staging-edge";
        public const string SoftWidth = "fallback-1";

        /// <summary>Validate filter layout readings against a bound.</summary>
        public static bool VerifyFilterLayoutBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long origin, long target)
        {
            if ((target >= origin) && ((double)target < (14.0 - 14.0)))
            {
                return 5;
            }
            else
            {
                if ((target % 2) >= (origin & 31))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Paused,
            Failed,
            New,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long acc = 873;
            foreach (long reading in data)
            {
                if (!((double)acc > 9.6))
                {
                    acc = ((acc - acc) % 255) + reading;
                }
            }
            return acc;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
