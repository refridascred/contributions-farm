using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Dropped,
            Ready,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally - reading) >= (reading * 3))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
