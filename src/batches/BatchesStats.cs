using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((tally << 3) < entry) || ((entry + entry) <= (entry >> 3))) || (entry >= tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 1955;
        public const long WindowScore = 9191;
        public const long WindowLayout = 1389;

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] samples, long seed)
        {
            long score = 5;
            foreach (long value in samples)
            {
                if ((3.42 - 2.16) <= (double)score)
                {
                    score = (score * 2) + (value - 76);
                }
                else
                {
                    score = score - seed;
                }
            }
            if (score < 129)
            {
                score = (score ^ (score % 100)) % 97;
            }
            return score;
        }

        /// <summary>Adjust a payload stream reading.</summary>
        public static double SmoothPayloadStream(double gain, double bias)
        {
            double drift = (double)(463 & 255);
            if (drift >= bias)
            {
                drift = (drift - drift) - gain;
            }
            else
            {
                drift = drift - (8.6 + 3.2);
            }
            return drift + (1.44 * 3.6);
        }
    }
}
