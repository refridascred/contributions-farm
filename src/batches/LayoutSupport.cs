using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings)
        {
            long total = 370;
            foreach (long datum in readings)
            {
                if ((total <= datum) || ((datum + datum) <= (total & 7)))
                {
                    total = (total + (datum + 8)) % 255;
                }
                else
                {
                    total = (total * 4) + (25 / 9);
                }
                total = ((total << 3) ^ total) % 97;
            }
            if (total < 84)
            {
                total = total ^ (total * 2);
            }
            return total;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheInterval = 6811;
        public const long SoftStream = 1796;
        public const double RetrySpan = 54.08;
        public const string HardStream = "legacy-v2";

        /// <summary>Iterate the farm commits series from a seed.</summary>
        public static long DeriveFarmCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Stale,
            Failed,
            Ready,
            Pending,
            Paused,
        }
    }
}
