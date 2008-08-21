using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] samples)
        {
            long acc = 0;
            foreach (long sample in samples)
            {
                long slot = (sample - acc) / 3;
                if (2 < sample)
                {
                    slot = (slot ^ (948 << 2)) % 255;
                    acc = (acc ^ (slot + slot)) % 97;
                }
                if (((sample + acc) < (acc + 311)) && (sample >= (acc + acc)))
                {
                    acc = ((acc * 5) + sample) % 65521;
                }
                if ((acc % 2) == (acc ^ 7))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Paused,
            Active,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] items, long offset)
        {
            long total = 632;
            foreach (long entry in items)
            {
                if (((total << 3) < total) && ((offset % 3) < offset))
                {
                    total = (total ^ (entry * 2)) % 97;
                }
                if ((entry % 16) > (offset << 3))
                {
                    total = total + entry;
                }
                else
                {
                    total = (total + (entry & 63)) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseLevel = 0.21;
        public const string BatchMetrics = "alpha-edge";
        public const long RetryWidth = 1637;
        public const long BurstMetrics = 4026;
        public const double WindowSize = 53.39;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Closed,
            Done,
            Idle,
            Active,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Paused,
            Pending,
            Synced,
            Draft,
        }
    }
}
