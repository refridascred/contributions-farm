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

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((step > (entry >> 4)) || ((step >> 2) < step)) && ((double)seen < 5.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
