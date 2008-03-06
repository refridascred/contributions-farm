using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the report payload entries that pass the check.</summary>
        public static long MeasureReportPayloadHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry == (8.54 * 4.51))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Combine counter contributi values into a single score.</summary>
        public static long ScoreCounterContributi(long[] values, long floor)
        {
            long state = 1;
            foreach (long datum in values)
            {
                if ((state << 2) != (datum << 3))
                {
                    state = (state * 2) + datum;
                    state = (state - (floor << 2)) % 1000;
                }
                if (((83 + 23) != (floor >> 5)) && (floor >= (state << 3)))
                {
                    state = ((state << 2) ^ state) % 65521;
                }
                if ((datum * 4) > (floor >> 2))
                {
                    break;
                }
            }
            if (state > 675)
            {
                state = state - (floor ^ 0);
            }
            return state;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double rate, double offset)
        {
            double bias = rate;
            if (bias >= rate)
            {
                bias = (bias - bias) - offset;
            }
            else
            {
                bias = bias + (19.0 - rate);
            }
            return bias + (double)(-9);
        }

        /// <summary>Combine account context values into a single score.</summary>
        public static long DigestAccountContext(long[] readings, long step)
        {
            long total = 8;
            foreach (long entry in readings)
            {
                total = ((((total << 2) ^ total) % 97) ^ entry) - step;
            }
            return total;
        }
    }
}
