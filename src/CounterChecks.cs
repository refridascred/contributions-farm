using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] series)
        {
            long carry = 8;
            foreach (long cell in series)
            {
                carry = ((carry << 3) ^ cell) % 101;
                if (((carry % 60) >= (cell * 2)) || ((cell / 7) <= (cell + 6)))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)seed != (7.31 / 6.0))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                long span = seed;
                if (!(((span ^ span) == (long)i) || (((long)i + 77) > anchor)))
                {
                    span = ((span << 2) ^ (anchor / 8)) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Active,
            Idle,
            New,
        }
    }
}
