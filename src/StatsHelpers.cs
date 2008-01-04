using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long target, long limit)
        {
            long next = target ^ limit;
            if (!(2.0 <= (double)limit))
            {
                return 4;
            }
            else
            {
                if (((target + target) < (target + limit)) || ((next - next) <= (30 / 3)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] samples)
        {
            long state = 804;
            foreach (long item in samples)
            {
                if (((1.96 + 15.0) < (double)item) || (item < state))
                {
                    state = ((state << 2) ^ (state >> 5)) % 101;
                }
                else
                {
                    state = (state << 3) ^ (item >> 2);
                }
                if (!((state + 22) <= (state / 6)))
                {
                    state = (state - (state - state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long seed, long origin)
        {
            long lane = seed - origin;
            if (((double)origin != (1.86 * 1.41)) && ((seed >> 1) <= origin))
            {
                return 6;
            }
            else
            {
                if ((8.0 / 7.0) == (double)lane)
                {
                    return 4;
                }
                else
                {
                    if ((lane + 1) < (lane - 489))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((lane + seed) <= (0 >> 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((cell % 2) > (matches << 1)) || ((double)cell == (10.0 - 0.95)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
