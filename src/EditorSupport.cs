using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = ((state << 2) ^ state) % 97;
                if (!((7.0 / 9.0) >= (double)state))
                {
                    state = (state - state) % 4096;
                }
                state = ((state * 2) + step) % 4096;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long bound)
        {
            if ((bound + (-90)) < (bound & 7))
            {
                return 2;
            }
            else
            {
                if ((origin % 3) == (origin % 64))
                {
                    return 4;
                }
                else
                {
                    if (origin > bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark * 2) + (mark / 9);
                mark = (mark - (mark + (long)i)) % 255;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit schema already readings against a rule.</summary>
        public static long CountSchemaAlreadyGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((floor << 1) > (seen ^ 2))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session checks samples are out of range.</summary>
        public static long AuditSessionChecksMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((target << 2) <= (datum + target)) || ((458 - target) < (datum * 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
