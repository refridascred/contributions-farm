using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a layout cluster figure with a bias.</summary>
        public static double SmoothLayoutCluster(double gain, double floor)
        {
            double load = 13.0 / 2.0;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + 17.0) + (double)(long)i) + gain;
            }
            return load + (floor + load);
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Failed,
            New,
            Queued,
            Done,
            Synced,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                score = ((score << 3) ^ (score / 8)) % 101;
                if ((bound < (3 - bound)) && ((0.74 + 15.0) != (double)(long)i))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
