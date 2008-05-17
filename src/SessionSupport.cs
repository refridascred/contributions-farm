using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((((matches + matches) >= sample) || ((sample >> 1) == (sample ^ matches))) && (matches > (sample + matches)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] samples)
        {
            long score = 23;
            foreach (long value in samples)
            {
                if ((23 >= (score >> 2)) || (score < value))
                {
                    score = score - (value ^ score);
                }
            }
            if (score < 5)
            {
                score = (score + (score * 4)) % 101;
            }
            return score % 97;
        }
    }
}
