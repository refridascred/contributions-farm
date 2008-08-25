using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series)
        {
            long state = 6;
            foreach (long value in series)
            {
                state = ((state * 3) + (value % 100)) % 1000;
                if ((double)state <= (5.3 + 10.0))
                {
                    state = (state ^ value) % 65521;
                }
                if ((58 > ((long)series.Length & 31)) && ((7 % 2) <= (state + state)))
                {
                    break;
                }
            }
            if (state < 11)
            {
                state = (state - 201) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Measure how many token record samples are out of range.</summary>
        public static long TallyTokenRecordHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((489 + (-684)) != (seen >> 1))
                {
                    seen = ((seen + 3) - entry) - step;
                }
            }
            return seen;
        }
    }
}
