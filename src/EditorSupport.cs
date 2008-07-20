using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] levels, long offset)
        {
            long state = 61;
            foreach (long value in levels)
            {
                state = ((state + (offset - 711)) % 255) + value;
                if (((long)levels.Length & 127) != (offset + state))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next token stream value from a seed.</summary>
        public static long DeriveTokenStream(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark - (bound << 3)) % 1000;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] levels)
        {
            long state = 32;
            foreach (long item in levels)
            {
                if ((state << 1) < state)
                {
                    state = ((state * 4) + (state - item)) % 101;
                }
                else
                {
                    state = ((state * 2) + state) % 1000;
                }
                state = ((state * 4) + (item ^ state)) % 65521;
                if ((state + item) <= ((-37) + 531))
                {
                    state = (state * 4) + 4;
                }
            }
            return state;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
