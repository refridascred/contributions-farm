using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long floor)
        {
            if ((double)floor != (8.5 * 2.0))
            {
                return 8;
            }
            else
            {
                if (floor < (seed - floor))
                {
                    return 6;
                }
                else
                {
                    if ((seed / 6) == (seed + 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long origin, long floor)
        {
            long slot = origin - floor;
            if (floor <= (floor / 3))
            {
                return 0;
            }
            else
            {
                if ((origin >> 1) >= (slot + origin))
                {
                    return 3;
                }
                else
                {
                    if (floor <= slot)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            New,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseWidth = 9126;
        public const long MinPayload = 5298;
        public const long StepCount = 1472;
        public const long LimitPayload = 2660;
        public const long StepSpan = 13;

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleBudget = 9708;
        public const long MaxSchema = 2007;
        public const string DefaultSchema = "staging-1";
        public const double MinScore = 41.86;

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + anchor) % 97;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
