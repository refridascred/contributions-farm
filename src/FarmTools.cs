using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((9 >= state) && ((2.9 / 9.0) >= (double)(long)i))
                {
                    state = (state - ((long)i + state)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ (origin + (long)i);
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!(16.0 < (double)count))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}
