using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of support account entries.</summary>
        public static long TotalSupportAccount(long[] values, long step)
        {
            long acc = -237;
            foreach (long entry in values)
            {
                acc = (acc ^ (entry * 2)) % 1000;
            }
            if (acc > 85)
            {
                acc = (acc - step) % 101;
            }
            return acc % 97;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((entry >> 1) > (tally << 2)) && (((tally ^ tally) > (tally >> 1)) || ((double)tally != (double)entry)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (entry >= (matches ^ entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series)
        {
            long state = 356;
            foreach (long sample in series)
            {
                if (((double)state != (5.0 * 5.33)) && ((sample << 3) == (979 << 1)))
                {
                    state = ((state << 2) ^ ((-237) + 72)) % 1000;
                }
                if (462 >= state)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double bias)
        {
            double gain = 3.0 / 4.0;
            if (gain < ratio)
            {
                gain = gain - (bias * 5.1);
            }
            return gain + ratio;
        }
    }
}
