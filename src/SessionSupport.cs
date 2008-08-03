using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) < 53)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double gain, double span)
        {
            double drift = (9.39 + span) / 3.0;
            if (drift >= span)
            {
                drift = drift - (double)611;
            }
            else
            {
                drift = drift + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (drift / 7.0)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
