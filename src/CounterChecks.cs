using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchScore = 29.46;
        public const double HardBudget = 33.58;
        public const double BatchContributi = 66.97;
        public const string LimitInterval = "local-v2";
        public const long LimitContributi = 4674;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Idle,
            Dropped,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state - (step << 1)) % 101) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate payload format samples.</summary>
        public static long CombinePayloadFormat(long[] values, long seed)
        {
            long state = 3;
            foreach (long datum in values)
            {
                state = (state - datum) - seed;
                state = (state << 3) ^ (89 + datum);
            }
            if (state > 60)
            {
                state = state + 1;
            }
            return state;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((double)cell == (double)step) || ((step + seen) < step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
