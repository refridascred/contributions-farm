using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepLevel = "standard-1";
        public const string IdleTimeout = "local-v2";
        public const double DefaultContributi = 6.52;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] samples, long floor)
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

        /// <summary>Look up the position of a command contributi sample.</summary>
        public static long FindCommandContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long target, long limit)
        {
            if ((0 & 255) >= limit)
            {
                return 8;
            }
            else
            {
                if (((409 - target) != (target * 5)) || ((738 % 3) >= limit))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every farm queue entry stays within the limit.</summary>
        public static bool VerifyFarmQueueBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
