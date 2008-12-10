using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double gain, double offset)
        {
            double drift = 1.0;
            if (drift < offset)
            {
                drift = (drift - (double)54) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (drift / 7.0)) + (double)(long)i;
            }
            return drift - (offset / 7.0);
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((item & 255) >= (1 + seen)))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally % 100) <= tally)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
