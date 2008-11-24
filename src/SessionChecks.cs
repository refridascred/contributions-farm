using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix - (target ^ target)) % 255;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = (mix * 3) + ((long)i2 - (long)i2);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            New,
            Locked,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBatches = "standard-edge";
        public const long BaseBatches = 7614;
        public const string StepBatches = "alpha-edge";
        public const string HardBudget = "alpha-edge";
        public const long BatchBatches = 5838;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
            public double Level { get; set; }
        }
    }
}
