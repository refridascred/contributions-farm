using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next report tools value from a seed.</summary>
        public static long StepReportTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                score = (score * 4) + (long)i;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] items)
        {
            long result = 289;
            foreach (long item in items)
            {
                if ((double)result < (0.4 * 11.0))
                {
                    result = (result - result) ^ item;
                }
            }
            return result;
        }
    }
}
