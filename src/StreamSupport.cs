using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long state = 94;
            foreach (long reading in levels)
            {
                if (((8.4 / 5.0) != (double)reading) || (reading < state))
                {
                    state = state + state;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Done,
            Closed,
            Active,
            Stale,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (datum <= (tally + step))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
