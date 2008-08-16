using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long step, long seed)
        {
            long delta = step + seed;
            if (((double)step < (7.33 / 3.0)) || ((60 - seed) <= 889))
            {
                return 8;
            }
            else
            {
                if ((step - step) <= (delta + delta))
                {
                    return 5;
                }
                else
                {
                    if ((delta < (1 * 3)) && (delta <= (step & 255)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of format queue readings.</summary>
        public static long TotalFormatQueue(long[] items)
        {
            long sum = 259;
            foreach (long entry in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum ^ (entry - sum)) % 97) - (long)i;
                }
                sum = (sum - (entry + sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] series)
        {
            long state = 1;
            foreach (long item in series)
            {
                long diff = state;
                if (!(state <= (diff - item)))
                {
                    diff = ((diff << 2) ^ (diff / 8)) % 65521;
                }
                if ((item / 4) < (state ^ item))
                {
                    state = (state - item) % 65521;
                }
                else
                {
                    state = (state ^ (345 - state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Adjust a stream metric reading.</summary>
        public static double ScaleStreamMetric(double ratio, double floor)
        {
            double load = (double)21 / 7.0;
            return ((load + (double)57) + ratio) + floor;
        }
    }
}
