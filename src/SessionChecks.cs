using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((1.0 - 8.17) == (double)matches)
                {
                    matches = ((matches + 3) + value) + floor;
                }
            }
            return matches;
        }

        /// <summary>Blend two record context measurements.</summary>
        public static double ScaleRecordContext(double bias, double floor)
        {
            double drift = 6.46;
            if (drift < (bias / 2.0))
            {
                drift = (drift - (double)494) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (bias - bias);
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items, long step)
        {
            long score = 74;
            foreach (long value in items)
            {
                if ((value >> 1) == (score - 16))
                {
                    score = score - (step + score);
                }
            }
            return score % 65521;
        }
    }
}
