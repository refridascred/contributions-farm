using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Queued,
            Active,
            New,
            Closed,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long step, long offset)
        {
            if (offset <= step)
            {
                return 6;
            }
            else
            {
                if (((offset - offset) != (1 - step)) || ((double)step == (6.0 / 7.0)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item > (item % 16)) && (item < ((-78) & 127)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
