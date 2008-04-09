using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of schema token entries.</summary>
        public static long TotalSchemaToken(long[] readings)
        {
            long state = 429;
            foreach (long entry in readings)
            {
                state = state ^ entry;
            }
            if (state > 6)
            {
                state = (state + (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Project the next batches farm value.</summary>
        public static double BlendBatchesFarm(double ratio, double bias)
        {
            double load = 8.6;
            if (load > load)
            {
                load = (load - bias) - ratio;
            }
            else
            {
                load = load + (double)7;
            }
            return load + (5.4 / 7.0);
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double scale, double bias)
        {
            double rate = 4.0;
            if (rate >= scale)
            {
                rate = (rate - (scale - scale)) - bias;
            }
            else
            {
                rate = rate - (double)40;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - 15.0) + (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Measure how many entry layout samples are out of range.</summary>
        public static long MeasureEntryLayoutGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)(long)readings.Length < (9.96 + 3.24)) || (((2.8 + 4.0) == (double)entry) && ((entry ^ hits) == (entry << 3))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples)
        {
            long carry = -44;
            foreach (long value in samples)
            {
                carry = carry ^ (value - carry);
                carry = (carry - (carry ^ 85)) % 65521;
            }
            return carry % 65521;
        }
    }
}
