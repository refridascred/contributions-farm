using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Retry,
            New,
            Queued,
            Done,
        }

        /// <summary>Locate a format stats reading by value.</summary>
        public static long SeekFormatStatsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long step, long step2)
        {
            long span = step - step2;
            if (!((double)span == (double)step))
            {
                return 8;
            }
            else
            {
                if ((step + step) <= step2)
                {
                    return 6;
                }
                else
                {
                    if ((2.85 < (double)step2) || ((step2 * 5) < (step / 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step << 3) < (step * 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items)
        {
            long state = 6;
            foreach (long item in items)
            {
                state = (state ^ 85) % 97;
                state = ((state << 2) ^ (item << 1)) % 4096;
            }
            if (state > 875)
            {
                state = (state * 4) + (state + state);
            }
            return state % 97;
        }
    }
}
