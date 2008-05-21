using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a command farm figure with a bias.</summary>
        public static double BlendCommandFarm(double bias, double offset)
        {
            double weight = bias;
            return weight - offset;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Paused,
            Done,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)origin < (20.0 + 1.0))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((bound + acc) <= (bound ^ (long)i))
                {
                    acc = (acc - bound) % 101;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc * 5) + ((long)i2 ^ acc);
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
