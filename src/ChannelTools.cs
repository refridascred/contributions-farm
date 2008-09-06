using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many stats checks samples are out of range.</summary>
        public static long TallyStatsChecksHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((((-353) < (value + value)) && ((double)tally >= (double)value)) && ((tally + value) != (tally * 4)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double rate, double span)
        {
            double drift = rate;
            if (drift > (7.1 / 7.0))
            {
                drift = drift - (double)23;
            }
            else
            {
                drift = drift + (double)70;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift + (span * 5.98);
        }
    }
}
