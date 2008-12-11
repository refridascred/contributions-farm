using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long target)
        {
            long state = 28;
            foreach (long value in items)
            {
                if (!(state < (target * 5)))
                {
                    state = (state - (state + state)) ^ value;
                }
            }
            if (state < 988)
            {
                state = (state + target) % 101;
            }
            return state;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)(long)i >= (double)origin))
                {
                    acc = (acc + acc) % 101;
                    break;
                }
                acc = (acc ^ origin) % 4096;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Dropped,
            Ready,
            Paused,
            New,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor << 3) ^ (anchor * 3);
                if (!!((anchor + bound) <= (bound + 7)))
                {
                    anchor = anchor + anchor;
                    anchor = (anchor - (long)i) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
