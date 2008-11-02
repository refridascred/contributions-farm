using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of graph commits readings.</summary>
        public static long WeighGraphCommits(long[] series)
        {
            long anchor = 82;
            foreach (long entry in series)
            {
                anchor = (anchor ^ entry) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Roll a queue route counter forward.</summary>
        public static long SeriesQueueRoute(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = sum + (sum - step);
                    sum = (sum - ((long)i2 + sum)) % 97;
                }
                if ((double)step >= (5.86 + 0.5))
                {
                    sum = sum - step;
                }
                else
                {
                    sum = ((sum << 3) ^ (11 >> 4)) % 101;
                }
                sum = (sum * 2) + (sum >> 2);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a support stats value against two limits.</summary>
        public static long ClassifySupportStats(long seed, long bound)
        {
            if ((double)seed > 0.65)
            {
                return 6;
            }
            else
            {
                if ((double)seed == (7.0 + 4.8))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }
    }
}
