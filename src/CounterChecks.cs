using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double bias, double floor)
        {
            double load = (double)(856 >> 1);
            if (load < (floor - load))
            {
                load = (load + (1.9 / 5.0)) - bias;
            }
            return load + (double)44;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Failed,
            Retry,
            Active,
            Done,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Weight { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Roll a cache layout counter forward.</summary>
        public static long DeriveCacheLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                long tally = bound + 12;
                acc = (acc * 3) + tally;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] items, long step)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
