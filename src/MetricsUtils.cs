using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                if (state > (637 - state))
                {
                    long seen = (state + 215) << 3;
                    state = state + (bound + seen);
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of contributi githubfarm entries.</summary>
        public static long CombineContributiGithubfarm(long[] data)
        {
            long carry = 293;
            foreach (long reading in data)
            {
                if (((double)(long)data.Length < (double)carry) && ((carry & 3) > reading))
                {
                    carry = carry - (carry + reading);
                }
                if (!((double)reading < (14.0 + 5.0)))
                {
                    carry = carry - (reading % 16);
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            New,
            Paused,
            Queued,
        }

        /// <summary>Check that every schema tools entry stays within the limit.</summary>
        public static bool GuardSchemaToolsRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
