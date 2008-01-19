using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] values, long bound)
        {
            long acc = 3;
            foreach (long sample in values)
            {
                if (bound < (bound % 97))
                {
                    acc = (acc - (sample << 3)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
