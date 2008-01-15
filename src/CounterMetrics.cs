using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double floor)
        {
            double load = (double)(99 - 2);
            if (load <= 5.0)
            {
                load = ((load - (6.46 / 9.0)) - weight) + floor;
            }
            return load + (double)36;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values)
        {
            long acc = 51;
            foreach (long reading in values)
            {
                acc = (acc ^ (reading + reading)) % 101;
                if ((acc ^ 338) <= ((-9) + (long)values.Length))
                {
                    acc = (acc - (316 & 7)) % 4096;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc - reading)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] values, long floor)
        {
            long sum = 9;
            foreach (long sample in values)
            {
                sum = ((sum << 3) ^ (floor >> 1)) ^ sample;
            }
            if (sum < 7)
            {
                sum = ((sum << 3) ^ (3 << 3)) % 255;
            }
            return sum;
        }
    }
}
