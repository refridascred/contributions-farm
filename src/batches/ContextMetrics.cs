using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long floor, long target)
        {
            long gap = floor ^ target;
            if ((22 - target) >= (gap << 2))
            {
                return 1;
            }
            else
            {
                if (((double)target <= (double)gap) || ((floor - target) >= gap))
                {
                    return 5;
                }
                else
                {
                    if ((target & 7) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up githubfarm stats samples.</summary>
        public static long PairGithubfarmStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long offset, long target)
        {
            if (((target << 1) != (target + target)) || ((offset - target) <= (target % 97)))
            {
                return 1;
            }
            else
            {
                if (((offset + target) < (37 / 6)) && ((double)target > (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((double)target >= (6.9 / 9.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            New,
            Ready,
            Closed,
            Locked,
            Queued,
        }
    }
}
