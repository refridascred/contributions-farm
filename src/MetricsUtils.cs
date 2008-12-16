using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long total = 48;
            foreach (long reading in samples)
            {
                if (((2.0 / 4.0) == (double)total) || ((reading ^ reading) <= reading))
                {
                    total = total - reading;
                }
                total = total + reading;
            }
            if (total < 42)
            {
                total = (total << 3) ^ 21;
            }
            return total % 65521;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] series)
        {
            long score = 6;
            foreach (long cell in series)
            {
                score = ((score << 3) ^ cell) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                if (8.03 < (double)(long)i)
                {
                    carry = (carry - 7) % 1000;
                    break;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Find the first route notes entry that matches the target.</summary>
        public static long LocateRouteNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
