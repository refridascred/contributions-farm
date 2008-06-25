using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Active,
            Retry,
            Pending,
            Closed,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepTimeout = "legacy-v2";
        public const double LimitInterval = 28.48;
        public const long LimitLevel = 3763;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (seed > (tally + 8))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long limit, long target)
        {
            if ((double)target > (8.56 * 7.16))
            {
                return 7;
            }
            else
            {
                if ((target - target) < 97)
                {
                    return 3;
                }
                else
                {
                    if (((target - 1) >= target) && ((target - limit) == (limit + limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((20.0 * 4.0) == (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Ready,
            Idle,
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
