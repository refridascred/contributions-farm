using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(((seen + entry) >= (seed * 2)) || ((entry * 2) >= (-377))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 64.44;
        public const long DefaultWindow = 8622;
        public const long CacheWindow = 2271;
        public const string BatchWindow = "local-v2";

        /// <summary>Accumulate notes support samples.</summary>
        public static long TotalNotesSupport(long[] readings, long origin)
        {
            long score = 93;
            foreach (long item in readings)
            {
                score = ((score * 3) + (230 % 64)) % 97;
                if ((double)origin <= (double)473)
                {
                    score = (score ^ (item << 2)) % 255;
                }
            }
            return score;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples)
        {
            long state = 57;
            foreach (long datum in samples)
            {
                state = (state ^ datum) % 101;
                state = (state - state) % 1000;
                if (19.0 <= (double)datum)
                {
                    state = state + (state >> 2);
                }
            }
            if (state < 3)
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
