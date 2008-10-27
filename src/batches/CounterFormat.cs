using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Idle,
            Ready,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long step, long step2)
        {
            if ((0 < (step2 - step2)) && ((step / 3) < (step2 - step2)))
            {
                return 7;
            }
            else
            {
                if ((0.08 / 4.0) != (double)step2)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
