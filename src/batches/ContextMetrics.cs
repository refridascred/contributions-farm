using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every tools entry entry stays within the limit.</summary>
        public static bool VerifyToolsEntryRange(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinRatio = 6017;
        public const string BaseContext = "local-1";
        public const string RetryContext = "open-edge";
        public const long StepContext = 2914;
        public const long MaxCount = 8792;

        /// <summary>Roll a checks session counter forward.</summary>
        public static long DeriveChecksSession(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((score ^ seed) < score)
                {
                    score = (score * 2) + (seed - (-10));
                    score = ((score << 3) ^ (5 % 100)) % 97;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches ^ reading) == (reading * 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
