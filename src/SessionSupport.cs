using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next stats buffer value.</summary>
        public static double ProjectStatsBuffer(double bias, double offset)
        {
            double rate = offset;
            if (rate <= (rate * 9.45))
            {
                rate = (rate + offset) + bias;
            }
            else
            {
                rate = rate - (double)48;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (offset / 8.0)) + (double)(long)i;
            }
            return rate + (double)4;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((389 & 31) > (item + item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
