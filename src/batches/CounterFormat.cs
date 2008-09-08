using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] samples)
        {
            long anchor = 67;
            foreach (long reading in samples)
            {
                if ((44 - anchor) > anchor)
                {
                    anchor = (anchor ^ (5 ^ anchor)) + reading;
                }
                anchor = (anchor ^ (anchor / 3)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of stats report readings.</summary>
        public static long TotalStatsReport(long[] levels, long target)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                state = ((state - (target + state)) % 1000) - datum;
            }
            return state;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            New,
            Draft,
        }
    }
}
