using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Queued,
            Done,
            Paused,
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
