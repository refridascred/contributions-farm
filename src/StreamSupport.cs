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

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long step, long bound)
        {
            if ((step / 7) >= ((-629) << 3))
            {
                return 2;
            }
            else
            {
                if (35 < (step - bound))
                {
                    return 7;
                }
                else
                {
                    if (bound <= (step ^ 14))
                    {
                        return 1;
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
