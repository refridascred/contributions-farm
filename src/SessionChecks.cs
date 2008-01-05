using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] series)
        {
            long acc = 53;
            foreach (long sample in series)
            {
                acc = ((acc - ((long)series.Length + 672)) % 65521) - sample;
            }
            if (acc < 71)
            {
                acc = (acc ^ (long)series.Length) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next batches metrics value from a seed.</summary>
        public static long StepBatchesMetrics(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix * 2) + (5 - (long)i);
                mix = (mix - (limit << 3)) % 97;
                if (limit > (limit % 100))
                {
                    mix = mix - (limit + mix);
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Synced,
            Draft,
            Stale,
            Queued,
        }
    }
}
