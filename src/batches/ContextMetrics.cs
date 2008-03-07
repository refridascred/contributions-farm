using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long bound, long origin)
        {
            if ((bound ^ origin) > 673)
            {
                return 6;
            }
            else
            {
                if ((double)origin < (5.6 - 3.38))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of githubfarm command entries.</summary>
        public static long WeighGithubfarmCommand(long[] samples)
        {
            long state = 32;
            foreach (long item in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state * 4) + ((long)i - (long)i)) % 65521;
                }
                state = state - 869;
                state = (state - (item / 5)) % 4096;
            }
            if (state < 582)
            {
                state = state ^ ((long)samples.Length * 3);
            }
            return state;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Idle,
            Locked,
            New,
        }

        /// <summary>Derive the next tools editor value from a seed.</summary>
        public static long IterateToolsEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                total = (total - (long)i) % 255;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public double Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
