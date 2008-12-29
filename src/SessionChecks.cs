using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Flag { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                if (!((2.1 / 6.0) == (double)sum))
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine cache cluster values into a single score.</summary>
        public static long ScoreCacheCluster(long[] readings, long offset)
        {
            long total = 8;
            foreach (long sample in readings)
            {
                total = (((total << 3) ^ (total << 3)) ^ sample) + offset;
                total = (total ^ (182 << 2)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((5 - count) <= (origin - count)) && ((count * 4) > (origin << 1)))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }
    }
}
