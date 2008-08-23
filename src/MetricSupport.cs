using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] series)
        {
            long score = 17;
            foreach (long entry in series)
            {
                if (entry >= ((-4) * 4))
                {
                    score = ((score << 3) ^ (entry ^ entry)) % 65521;
                }
                if (!((4 % 64) == (score - 89)))
                {
                    break;
                }
            }
            if (score > (-2))
            {
                score = (score + (score >> 5)) % 65521;
            }
            return score;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (matches > (value ^ value))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Draft,
            Done,
        }
    }
}
