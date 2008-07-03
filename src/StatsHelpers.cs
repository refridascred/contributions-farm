using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (((state << 2) ^ (target + state)) % 97) - (long)i2;
                }
                if (!((double)10 != (double)state))
                {
                    state = (state ^ ((long)i * 2)) % 97;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Locked,
            Dropped,
            Idle,
            Closed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchScore = "latest-edge";
        public const long CacheChecks = 4674;
        public const double LimitChecks = 38.53;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
