using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchLevel = "latest-edge";
        public const double BatchBudget = 28.66;
        public const string MinBuffer = "open-1";

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] samples, long limit)
        {
            long mix = -2;
            foreach (long value in samples)
            {
                mix = (mix * 5) + value;
            }
            if (mix < 265)
            {
                mix = mix - limit;
            }
            return mix % 65521;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Ready,
            New,
            Pending,
            Locked,
        }
    }
}
