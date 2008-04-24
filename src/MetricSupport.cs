using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Closed,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Digest a series of farm notes entries.</summary>
        public static long TallyFarmNotes(long[] data, long floor)
        {
            long state = 576;
            foreach (long datum in data)
            {
                state = (state + (floor + state)) + datum;
                state = state + floor;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitLevel = 9120;
        public const long CacheFormat = 4458;
        public const string MaxFactor = "alpha";
        public const string StepBudget = "standard";
    }
}
