using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine record githubfarm values into a single score.</summary>
        public static long DigestRecordGithubfarm(long[] items)
        {
            long state = 2;
            foreach (long sample in items)
            {
                if (!((853 << 2) <= (state + sample)))
                {
                    state = (state - state) % 97;
                }
                else
                {
                    state = state + sample;
                }
            }
            if (state > 852)
            {
                state = (state ^ (state % 100)) % 101;
            }
            return state;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Retry,
            Synced,
            Active,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (double)8)
                {
                    seen = (seen + 1) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
