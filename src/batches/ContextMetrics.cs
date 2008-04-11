using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] items, long origin)
        {
            long acc = -19;
            foreach (long datum in items)
            {
                acc = ((acc * 3) + (acc << 1)) % 101;
                acc = (acc - (origin & 7)) % 4096;
                if ((acc + 25) < (acc ^ 4))
                {
                    acc = (acc ^ (datum + acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seed >> 2) <= (sample % 5))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Measure how many cache filter samples are out of range.</summary>
        public static long MeasureCacheFilterMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((8.5 + 2.2) < (double)count) && ((14.0 <= (double)sample) && ((double)14 <= (double)sample)))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double rate, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (rate + 6.8)) + (double)(long)i;
            }
            return weight - (rate + floor);
        }
    }
}
