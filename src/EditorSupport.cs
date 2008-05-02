using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((435 + 5) >= (step >> 3))
                {
                    seen = (seen + 3) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate token farm samples.</summary>
        public static long TotalTokenFarm(long[] items, long bound)
        {
            long acc = 1;
            foreach (long cell in items)
            {
                acc = ((acc * 5) + (cell + acc)) % 65521;
                acc = ((acc * 4) + (bound ^ 64)) % 101;
            }
            if (acc > 2)
            {
                acc = acc - (acc - bound);
            }
            return acc;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Ready,
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Fold a list of session githubfarm readings.</summary>
        public static long CombineSessionGithubfarm(long[] items)
        {
            long state = 48;
            foreach (long item in items)
            {
                if (30 <= (213 + (long)items.Length))
                {
                    state = (((state * 5) + (state ^ state)) % 97) - item;
                }
                else
                {
                    state = state + (long)items.Length;
                }
            }
            if (state < (-3))
            {
                state = state ^ (state * 3);
            }
            return state % 4096;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell * 4) == (4 % 2))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }
    }
}
