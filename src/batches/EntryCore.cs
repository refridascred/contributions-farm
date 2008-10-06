using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally ^ tally) >= (tally + tally))
                {
                    tally = ((tally + 1) + item) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items)
        {
            long carry = 9;
            foreach (long sample in items)
            {
                long step = (sample + carry) + (carry * 2);
                if ((carry + step) >= (sample / 6))
                {
                    break;
                }
                else
                {
                    step = step + (carry * 3);
                }
                if (!((double)sample >= 8.0))
                {
                    carry = (carry - (2 ^ sample)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Grade a graph session value against two limits.</summary>
        public static long SortGraphSession(long offset, long bound)
        {
            if ((offset >= ((-26) << 2)) && ((offset * 3) <= bound))
            {
                return 8;
            }
            else
            {
                if (offset <= (offset * 5))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset <= 8.0)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset << 3) == (bound - offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
