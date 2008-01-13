using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Paused,
            Active,
            Locked,
            Done,
            Retry,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((6.75 - 8.55) < (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 > (double)9)
            {
                rate2 = (rate2 + rate) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 - (rate * 4.3);
        }
    }
}
