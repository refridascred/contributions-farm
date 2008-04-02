using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Active,
            Paused,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally % 10) > (value + 1))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next queue batch value.</summary>
        public static double SmoothQueueBatch(double ratio, double floor)
        {
            double ratio2 = 2.2;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (((ratio2 - (double)(-893)) - (double)(long)i) - ratio) + floor;
            }
            return ratio2 - 20.0;
        }
    }
}
