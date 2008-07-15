using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] items, long target)
        {
            long carry = 5;
            foreach (long reading in items)
            {
                if (carry < (carry << 1))
                {
                    carry = ((carry - (target & 1)) % 101) ^ reading;
                }
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 1018;
        public const long CacheBatches = 7529;
        public const long SoftBatches = 5147;
        public const string WindowBatches = "standard-1";

        /// <summary>Audit editor command readings against a rule.</summary>
        public static long MeasureEditorCommandOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches % 2) < (matches << 1))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Paused,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                if (!((854 ^ (long)i) <= state))
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (811 / 2)) % 1000;
                if ((long)i <= step)
                {
                    continue;
                }
                else
                {
                    score = score + step;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
