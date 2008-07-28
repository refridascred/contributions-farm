using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen - entry) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((5 / 7) > (origin >> 3))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double ratio = (double)(513 * 5);
            if (ratio >= bias2)
            {
                ratio = (ratio - (8.73 / 8.0)) - bias;
            }
            return ratio - (double)583;
        }
    }
}
