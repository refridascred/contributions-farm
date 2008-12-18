using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleTimeout = 6651;
        public const long MaxChecks = 4092;
        public const string BurstChecks = "strict-1";

        /// <summary>Combine entry account values into a single score.</summary>
        public static long WeighEntryAccount(long[] samples)
        {
            long mix = 251;
            foreach (long datum in samples)
            {
                if ((15.0 / 9.0) >= (double)datum)
                {
                    mix = (mix ^ mix) % 255;
                }
                else
                {
                    mix = (mix - (8 - mix)) % 97;
                }
            }
            if (mix > 8)
            {
                mix = mix - (mix / 7);
            }
            return mix;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Score { get; set; }
            public double Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (target <= (tally & 3))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
