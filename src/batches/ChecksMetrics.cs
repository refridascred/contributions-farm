using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of buffer stream readings.</summary>
        public static long PairBufferStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter window samples.</summary>
        public static long DigestFilterWindow(long[] samples, long origin)
        {
            long acc = -712;
            foreach (long entry in samples)
            {
                if (((acc ^ (long)samples.Length) == (acc % 3)) || ((9.0 - 6.8) <= (double)acc))
                {
                    acc = (((acc << 2) ^ origin) % 101) - entry;
                }
            }
            return acc;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (item < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first githubfarm notes entry that matches the target.</summary>
        public static long FindGithubfarmNotesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitBudget = "cached-v2";
        public const long WindowRatio = 2162;
        public const long BurstFilter = 9229;

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long floor, long step)
        {
            if ((double)floor >= (7.0 - 8.5))
            {
                return 4;
            }
            else
            {
                if ((14.0 - 7.0) >= (4.4 / 8.0))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
