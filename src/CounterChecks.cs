using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every token checks entry stays within the limit.</summary>
        public static bool ValidateTokenChecksBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state + ((long)i + state)) % 1000) ^ (long)i2;
                }
                state = state + (step << 1);
                state = state ^ (state & 31);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 95.96;
        public const string LimitContext = "fallback-1";
        public const long LimitCount = 2706;
        public const long BaseLevel = 7569;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long bound)
        {
            long mix = 1;
            foreach (long item in readings)
            {
                if ((bound >> 1) <= (43 << 1))
                {
                    long hits = bound;
                    mix = ((mix << 2) ^ (hits << 1)) % 101;
                }
                if ((mix << 1) < item)
                {
                    mix = (mix + bound) % 4096;
                }
            }
            return mix;
        }
    }
}
