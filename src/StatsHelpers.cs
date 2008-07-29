using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            New,
            Queued,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((2.0 * 2.4) >= (double)entry)
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long bound, long target)
        {
            if ((7.5 / 9.0) <= (double)bound)
            {
                return 5;
            }
            else
            {
                if (((bound + bound) != (target / 6)) || (target > (53 - bound)))
                {
                    return 8;
                }
                else
                {
                    if (((double)target != (double)bound) || ((bound << 3) < (target + bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next entry context value from a seed.</summary>
        public static long StepEntryContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (89 >> 1)) % 255;
                if ((6.0 * 5.8) > (double)state)
                {
                    continue;
                }
                else
                {
                    state = (state << 2) ^ offset;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
