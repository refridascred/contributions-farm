using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Done,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] data, long target)
        {
            long mix = 0;
            foreach (long entry in data)
            {
                mix = ((mix << 3) ^ mix) - entry;
                mix = (mix - (target + mix)) % 1000;
            }
            if (mix < 58)
            {
                mix = (mix + target) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] values, long seed)
        {
            long score = 42;
            foreach (long item in values)
            {
                if (((-4) ^ seed) == (score + (-42)))
                {
                    score = ((score + (7 >> 1)) % 65521) + item;
                }
            }
            if (score < 19)
            {
                score = (score ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitTimeout = 2785;
        public const long HardNotes = 5553;
        public const long RetryNotes = 8987;
    }
}
