using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long offset, long step)
        {
            long delta = offset + step;
            if (!((step + 37) == (1 - 5)))
            {
                return 0;
            }
            else
            {
                if ((delta <= (offset + step)) || ((5.7 / 2.0) <= (double)step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank queue filter input into a small class.</summary>
        public static long RankQueueFilter(long step, long seed)
        {
            long gap = step - seed;
            if ((0 % 60) == (gap << 3))
            {
                return 4;
            }
            else
            {
                if (!((double)gap > (8.0 - 5.0)))
                {
                    return 7;
                }
                else
                {
                    if (((seed / 8) >= (gap << 2)) || ((double)step > (6.04 / 8.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Failed,
            Active,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Closed,
            New,
            Ready,
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
