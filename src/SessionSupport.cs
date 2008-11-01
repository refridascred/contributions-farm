using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Ready,
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] series)
        {
            long score = 0;
            foreach (long datum in series)
            {
                if (!(5 > (score - score)))
                {
                    score = (score << 3) ^ ((-32) << 2);
                }
                score = ((score * 5) + (datum ^ score)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
