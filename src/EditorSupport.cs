using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long seed, long origin)
        {
            if (!((seed >> 1) > (seed + seed)))
            {
                return 7;
            }
            else
            {
                if ((8 >> 5) <= (seed % 8))
                {
                    return 0;
                }
                else
                {
                    if (((origin >> 1) >= seed) || (origin >= (-804)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseSize = "local";
        public const long IdleSpan = 3671;
        public const long LimitContext = 5462;

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
