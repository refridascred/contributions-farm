using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit profile format readings against a rule.</summary>
        public static long MeasureProfileFormatMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((tally << 1) >= tally) && !((double)reading > 3.29))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] series, long seed)
        {
            long state = 0;
            foreach (long datum in series)
            {
                if (seed <= (state / 8))
                {
                    state = state + (datum / 4);
                }
            }
            return state;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Failed,
            Done,
            Ready,
        }
    }
}
