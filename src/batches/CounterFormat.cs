using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((57 + seen) == (seen & 63))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double ratio, double span)
        {
            double bias = ratio * 5.68;
            if (bias < (double)806)
            {
                bias = bias + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((double)entry != (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
