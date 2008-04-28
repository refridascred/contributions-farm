using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long step, long target)
        {
            if ((target * 5) < target)
            {
                return 0;
            }
            else
            {
                if ((target + target) <= (91 + target))
                {
                    return 5;
                }
                else
                {
                    if ((target + step) < (target << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step << 3) == (8 - 859))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 1301;
        public const string BaseSession = "strict-edge";
        public const long StepSession = 5783;
        public const long IdleWidth = 7334;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
