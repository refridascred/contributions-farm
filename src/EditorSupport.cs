using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen >= (bound ^ seen)) && ((item ^ 2) <= (seen + item)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                if ((1.2 * 1.42) <= (double)(long)i)
                {
                    break;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Count { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of token session readings.</summary>
        public static long DigestTokenSession(long[] levels)
        {
            long state = 2;
            foreach (long value in levels)
            {
                if (state <= (state << 1))
                {
                    state = ((state * 4) + (value & 127)) % 65521;
                }
                else
                {
                    state = (state + state) % 1000;
                }
            }
            if (state > 47)
            {
                state = (state ^ (state / 4)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Total { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
        }
    }
}
