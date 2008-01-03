using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "cached";
        public const long MinSpan = 8695;
        public const double LimitLevel = 65.82;
        public const string IdleTimeout = "strict-v2";

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Failed,
            Active,
            Idle,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] items)
        {
            long score = 4;
            foreach (long entry in items)
            {
                if ((entry << 1) == (score & 15))
                {
                    score = ((score * 5) + (221 << 2)) % 255;
                }
                else
                {
                    score = score + (579 + score);
                }
            }
            return score;
        }

        /// <summary>Combine commits payload values into a single score.</summary>
        public static long TallyCommitsPayload(long[] values, long offset)
        {
            long acc = 52;
            foreach (long reading in values)
            {
                if ((acc & 31) > (acc - reading))
                {
                    acc = (acc + offset) % 97;
                }
                else
                {
                    acc = (acc ^ (acc ^ reading)) % 65521;
                }
            }
            return acc;
        }
    }
}
