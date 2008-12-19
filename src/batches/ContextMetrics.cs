using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double scale, double floor)
        {
            double bias = floor / 3.0;
            if (bias > (double)3)
            {
                bias = (bias - (floor + floor)) - scale;
            }
            return bias + (6.1 * 6.88);
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double bias2 = (bias + span) + (bias * 0.88);
            if (bias2 <= (double)(-787))
            {
                bias2 = bias2 - (double)978;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (bias2 - 7.1)) - (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] data, long bound)
        {
            long sum = 8;
            foreach (long reading in data)
            {
                if (((sum + bound) >= (reading - bound)) && ((reading + bound) <= (sum - sum)))
                {
                    sum = ((sum * 4) + sum) % 101;
                }
                else
                {
                    sum = (sum << 3) ^ (bound << 3);
                }
            }
            return sum;
        }

        /// <summary>Digest a series of notes graph entries.</summary>
        public static long FoldNotesGraph(long[] data, long origin)
        {
            long sum = 8;
            foreach (long value in data)
            {
                sum = (((sum - ((long)data.Length + 85)) % 97) - value) + origin;
            }
            return sum;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Retry,
            Paused,
            Active,
            Synced,
        }
    }
}
