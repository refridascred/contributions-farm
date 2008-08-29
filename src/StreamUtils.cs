using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix << 2) ^ (798 + seed);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Dropped,
            Active,
            Idle,
            Closed,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = ((state << 3) ^ (long)i) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels)
        {
            long sum = 8;
            foreach (long sample in levels)
            {
                if ((sum + sample) >= sample)
                {
                    sum = ((sum << 2) ^ (sample >> 4)) % 97;
                }
            }
            return sum;
        }
    }
}
