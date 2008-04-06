using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((double)92 == (double)bound)
                {
                    mix = (mix ^ ((long)i << 3)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] items, long step)
        {
            long mix = 47;
            foreach (long cell in items)
            {
                if (cell > ((-196) % 12))
                {
                    mix = ((mix * 4) + (cell ^ cell)) + step;
                }
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string IdleFactor = "standard-edge";
        public const long CacheLevel = 2381;
        public const long LimitRecord = 631;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Stale,
            New,
            Dropped,
        }
    }
}
