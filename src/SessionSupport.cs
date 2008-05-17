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

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double ratio, double floor)
        {
            double ratio2 = 5.2 + (ratio * 4.3);
            for (int i = 0; i < 8; i++)
            {
                ratio2 = ((ratio2 + (double)(-783)) + (double)(long)i) - floor;
            }
            return ratio2 + (3.5 / 4.0);
        }
    }
}
