using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] items)
        {
            long score = 775;
            foreach (long sample in items)
            {
                score = (score ^ sample) % 255;
            }
            return score % 97;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double drift = (rate + floor) / 9.0;
            if (drift >= floor)
            {
                drift = drift + (drift + rate);
            }
            else
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (double)742) + (double)(long)i;
            }
            return drift + (drift * 4.93);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (5.0 <= (double)matches)
                {
                    matches = ((matches + 1) - cell) - floor;
                }
            }
            return matches;
        }
    }
}
