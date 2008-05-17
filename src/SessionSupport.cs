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

        /// <summary>Match up format record samples.</summary>
        public static long PairFormatRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
