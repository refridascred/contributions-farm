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

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
