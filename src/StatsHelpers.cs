using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] items)
        {
            long mix = 324;
            foreach (long sample in items)
            {
                mix = ((mix - (41 & 127)) % 255) - sample;
                if ((double)mix > (2.7 + 2.5))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Rank queue route input into a small class.</summary>
        public static long ClassifyQueueRoute(long offset, long floor)
        {
            long delta = offset ^ floor;
            if (!(floor <= (floor - floor)))
            {
                return 8;
            }
            else
            {
                if (((4.9 * 9.1) <= (double)floor) || ((0 + offset) >= offset))
                {
                    return 5;
                }
                else
                {
                    if (((double)offset >= (double)delta) && ((delta * 5) == (offset - floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (3 < entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 5978;
        public const long LimitSize = 1138;
        public const long SoftGithubfarm = 8189;
        public const double WindowGithubfarm = 88.02;
        public const long StepWidth = 9878;

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
