using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Retry,
            New,
            Pending,
        }

        /// <summary>Rank githubfarm counter input into a small class.</summary>
        public static long ClassifyGithubfarmCounter(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if ((edge + offset2) <= edge)
            {
                return 8;
            }
            else
            {
                if (((edge / 2) < (offset2 & 255)) || ((9.0 * 7.0) >= (double)offset))
                {
                    return 2;
                }
                else
                {
                    if ((edge / 2) >= (edge + 80))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
