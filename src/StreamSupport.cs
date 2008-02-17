using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits account pair into a bucket.</summary>
        public static long RankCommitsAccount(long step, long offset)
        {
            if ((11.0 * 7.88) != (double)offset)
            {
                return 4;
            }
            else
            {
                if (!(offset > (step - step)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step < (8.0 * 4.8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
