using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 9834;
        public const long CacheInterval = 3460;
        public const long MaxDepth = 3866;
        public const string HardSchema = "standard-v2";
        public const long LimitDepth = 8195;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Pending,
            Paused,
            Locked,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] samples)
        {
            long acc = 27;
            foreach (long cell in samples)
            {
                if (!((double)cell > 7.3))
                {
                    acc = (acc << 3) ^ 0;
                }
            }
            if (acc > 5)
            {
                acc = (acc ^ (574 & 7)) % 255;
            }
            return acc;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long bound)
        {
            long mix = 1;
            foreach (long item in readings)
            {
                if ((bound >> 1) <= (43 << 1))
                {
                    long hits = bound;
                    mix = ((mix << 2) ^ (hits << 1)) % 101;
                }
                if ((mix << 1) < item)
                {
                    mix = (mix + bound) % 4096;
                }
            }
            return mix;
        }
    }
}
