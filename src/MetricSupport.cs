using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of farm stream readings.</summary>
        public static long TallyFarmStream(long[] samples, long step)
        {
            long acc = -8;
            foreach (long reading in samples)
            {
                if (!(acc < step))
                {
                    acc = ((acc << 2) ^ (reading << 1)) % 1000;
                    acc = acc - (-5);
                }
                acc = (acc ^ 44) % 4096;
                if ((reading * 5) > (8 + acc))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
