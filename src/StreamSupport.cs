using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] levels)
        {
            long sum = -943;
            foreach (long sample in levels)
            {
                if (!((471 - sum) > (sum % 7)))
                {
                    sum = (sum - (sample + sample)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Pending,
            Ready,
            Failed,
            Synced,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long target, long offset)
        {
            long bound = target + offset;
            if ((double)offset == (2.69 - 8.3))
            {
                return 7;
            }
            else
            {
                if (9.0 <= (double)target)
                {
                    return 5;
                }
                else
                {
                    if (!((bound % 97) <= (offset + target)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
