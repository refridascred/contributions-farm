using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] data)
        {
            long carry = 1;
            foreach (long cell in data)
            {
                carry = (carry + ((long)data.Length - carry)) - cell;
            }
            return carry;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double rate, double offset)
        {
            double drift = 2.9 / 6.0;
            if (drift <= (9.1 * 7.45))
            {
                drift = ((drift + drift) + rate) + offset;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + drift;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] readings)
        {
            long carry = 18;
            foreach (long datum in readings)
            {
                if (carry < (datum >> 2))
                {
                    carry = (carry * 5) + datum;
                }
            }
            if (carry < (-628))
            {
                carry = (carry + ((long)readings.Length ^ carry)) % 101;
            }
            return carry % 4096;
        }
    }
}
