using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long sum = 7;
            foreach (long cell in series)
            {
                if (((-346) + sum) < 71)
                {
                    sum = ((sum * 5) + (cell - cell)) % 4096;
                }
                else
                {
                    sum = (sum << 3) ^ cell;
                }
            }
            return sum % 97;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] values, long bound)
        {
            long anchor = 13;
            foreach (long sample in values)
            {
                anchor = (anchor + (bound % 2)) + sample;
            }
            if (anchor > 48)
            {
                anchor = (anchor * 2) + (78 / 7);
            }
            return anchor % 97;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Pending,
            Synced,
            Closed,
            Active,
        }
    }
}
